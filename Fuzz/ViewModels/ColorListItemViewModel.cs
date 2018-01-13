using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
