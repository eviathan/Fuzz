using Fuzz.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzz.Models
{
    public class PropertyItem
    {
        public string Name { get; set; }

        public float Value { get; set; }

        public float NormalisedValue
        {
            get
            {
                return Value / MaxValue;
            }
        }

        public float MaxValue
        {
            get
            {
                return Type == PropertyItemType.FloatType ? 1.0f : 255.0f;
            }
        }

        public PropertyItemType Type
        {
            get
            {
                return new List<string> { "AutomationLaneHeaderAlpha", "AutomationLaneClipBodyAlpha" }.Contains(Name) ? PropertyItemType.IntType : PropertyItemType.FloatType;
            }
        }

        internal string GetValue()
        {
            return Type == PropertyItemType.FloatType ? Value.ToString("F9") : ((byte)(Value * byte.MaxValue)).ToString();
        }
    }
}
