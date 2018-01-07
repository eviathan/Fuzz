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
        public float Value { get; set; }

        public float MaxValue { get; set; }

        public PropertyItemType Type { get; set; }

        internal string GetValue()
        {
            return (Type == PropertyItemType.FloatType ? Value : (int) Value).ToString();
        }
    }
}
