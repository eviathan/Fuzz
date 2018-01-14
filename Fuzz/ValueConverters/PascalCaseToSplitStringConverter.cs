using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Fuzz.ValueConverters
{
    [ValueConversion(typeof(string), typeof(string))]
    public class PascalCaseToSplitStringConverter : IValueConverter
    {
        public string ToSentenceCase(string str)
        {
            return Regex.Replace(str, "[a-z][A-Z]", m => $"{m.Value[0]} {char.ToLower(m.Value[1])}");
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ToSentenceCase(value.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
