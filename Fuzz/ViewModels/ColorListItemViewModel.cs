using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Fuzz.ViewModels
{
    public class ColorListItemViewModel : ViewModelBase
    {
        public string Name { get; set; }
        public Color Value { get; set; }
    }
}
