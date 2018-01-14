using Cyotek.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;

namespace Fuzz.ViewModels
{
    public class ColorListItemViewModel : ViewModelBase<ColorListItemViewModel>
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(x => x.Name);
            }
        }

        private Color _value;
        public Color Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(x => x.Value);
            }
        }

        public ICommand ColorSelected => new Command(() =>
        {
            Value = GetColor(Value);
        });

        private static int lastTop;
        private static int lastLeft;
        private static bool notFirstDialog;
        private Color GetColor(Color color = default(Color))
        {
            using (ColorPickerDialog dialog = new ColorPickerDialog())
            {
                dialog.Color = System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
                dialog.ShowAlphaChannel = true;

                if (notFirstDialog)
                {
                    dialog.StartPosition = FormStartPosition.Manual;
                }                    
                
                dialog.Top = lastTop;
                dialog.Left = lastLeft;

                notFirstDialog = true;

                dialog.PreviewColorChanged += Dialog_PreviewColorChanged;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    lastTop = dialog.Top;
                    lastLeft = dialog.Left;

                    return new Color()
                    {
                        A = dialog.Color.A,
                        B = dialog.Color.B,
                        G = dialog.Color.G,
                        R = dialog.Color.R
                    };
                }
            }

            return color;
        }

        private void Dialog_PreviewColorChanged(object sender, EventArgs e)
        {
            var colorDialog = sender as ColorPickerDialog;
            Value = new Color()
            {
                A = colorDialog.Color.A,
                B = colorDialog.Color.B,
                G = colorDialog.Color.G,
                R = colorDialog.Color.R
            };
        }
    }
}
