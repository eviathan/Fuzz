using Fuzz.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzz.ViewModels
{
    public class PropertyListItemViewModel : ViewModelBase<PropertyListItemViewModel>
    {
        private PropertyItemType _type;
        public PropertyItemType Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(x => x.Type);
            }
        }

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

        private float _value;
        public float Value
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
