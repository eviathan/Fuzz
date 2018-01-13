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

        private Color GetColor(Color color = default(Color))
        {
            var colorDialog = new ColorDialog()
            {
                Color = System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B),
                FullOpen = true,
                AllowFullOpen = true
            };

            colorDialog.ShowDialog();

            return new Color()
            {
                A = colorDialog.Color.A,
                B = colorDialog.Color.B,
                G = colorDialog.Color.G,
                R = colorDialog.Color.R
            };
        }
    }
}
