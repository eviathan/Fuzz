using Fuzz.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzz.ViewModels
{
    public class PropertyListItemViewModel : ViewModelBase
    {
        public PropertyItemType Type { get; set; } = PropertyItemType.FloatType;

        public string Name { get; set; }

        public string Value
        {
            get
            {
                return Type == PropertyItemType.FloatType ? FloatValue.ToString() : IntValue.ToString();
            }
        }

        public int IntValue { get; set; }

        public float FloatValue { get; set; }
    }
}
