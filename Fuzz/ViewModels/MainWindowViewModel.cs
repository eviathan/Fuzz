using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzz.ViewModels
{
    public class MainWindowViewModel : ViewModelBase<MainWindowViewModel>
    {
        private ObservableCollection<ColorListItemViewModel> _colors;
        public ObservableCollection<ColorListItemViewModel> Colors
        {
            get => _colors;
            set
            {
                _colors = value;
                OnPropertyChanged(x => x.Colors);
            }
        }
        public ObservableCollection<PropertyListItemViewModel> Properties { get; set; } = new ObservableCollection<PropertyListItemViewModel>();

        public MainWindowViewModel(Theme theme)
        {
            Colors = new ObservableCollection<ColorListItemViewModel>();
            Set(theme);            
        }

        public void Set(Theme theme)
        {
            foreach (var color in theme.Colors)
            {
                var c = Colors.FirstOrDefault(x => x.Name == color.Key);

                if (c != null)
                    c.Value = color.Value;
                else
                {
                    Colors.Add(new ColorListItemViewModel
                    {
                        Name = color.Key,
                        Value = color.Value
                    });
                }                
            }

            Colors.OrderBy(x => x.Name);

            foreach (var property in theme.Properties)
            {
                var p = Properties.FirstOrDefault(x => x.Name == property.Key);

                if (p != null)
                    p.FloatValue = property.Value.Value;
                else
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
}
