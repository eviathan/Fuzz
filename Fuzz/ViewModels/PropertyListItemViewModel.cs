using Fuzz.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzz.ViewModels
{
    public class PropertyListItemViewModel
    {
        public PropertyItemType Type { get; set; } = PropertyItemType.FloatType;

        public string Name { get; set; }

        public float Value { get; set; }
    }
}
