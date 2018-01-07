using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzz.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<ColorListItemViewModel> Colors { get; set; }
        public ObservableCollection<PropertyListItemViewModel> Properties { get; set; } = new ObservableCollection<PropertyListItemViewModel>();

        public MainWindowViewModel(Theme theme)
        {
            Colors = new ObservableCollection<ColorListItemViewModel>();

            foreach (var color in theme.Colors)
            {
                Colors.Add(new ColorListItemViewModel
                {
                    Name = color.Key,
                    Value = color.Value
                });
            }

            foreach(var property in theme.Properties)
            {
                Properties.Add(new PropertyListItemViewModel
                {
                    Name = property.Key,
                    FloatValue = property.Value.Value
                });
            }
        }
    }
}
