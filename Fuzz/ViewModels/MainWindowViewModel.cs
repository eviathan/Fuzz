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
        public ObservableCollection<ColorListItemViewModel> Colors { get; set; } = new ObservableCollection<ColorListItemViewModel>();
        public ObservableCollection<PropertyListItemViewModel> Properties { get; set; } = new ObservableCollection<PropertyListItemViewModel>();
    }
}
