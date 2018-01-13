using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;

namespace Fuzz.ViewModels
{
    public class MainWindowViewModel : ViewModelBase<MainWindowViewModel>
    {
        private CollectionViewSource colorCollection;
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

        public ICollectionView ColorSourceCollection
        {
            get
            {
                return colorCollection.View;
            }
        }

        private ObservableCollection<PropertyListItemViewModel> _properties;
        public ObservableCollection<PropertyListItemViewModel> Properties
        {
            get => _properties;
            set
            {
                _properties = value;
                OnPropertyChanged(x => x.Properties);
            }
        }

        private ColorListItemViewModel _selectedColor;
        public ColorListItemViewModel SelectedColor
        {
            get => _selectedColor;
            set
            {
                _selectedColor = value;
                OnPropertyChanged(x => x.SelectedColor);
            }
        }

        private string _windowTitle;
        public string WindowTitle
        {
            get => _windowTitle;
            set
            {
                _windowTitle = value;
                OnPropertyChanged(x => x.WindowTitle);
            }
        }

        public MainWindowViewModel(Theme theme)
        {
            Colors = new ObservableCollection<ColorListItemViewModel>();
            Properties = new ObservableCollection<PropertyListItemViewModel>();
            Set(theme);

            colorCollection = new CollectionViewSource();
            colorCollection.Source = Colors;
            colorCollection.Filter += ColorCollection_Filter;
        }

        private void ColorCollection_Filter(object sender, FilterEventArgs e)
        {
            // TODO: Implent filter here
            e.Accepted = true;
        }

        public void Set(Theme theme)
        {
            foreach (var color in theme.Colors.OrderBy(x => x.Key))
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
            
            foreach (var property in theme.Properties.OrderBy(x => x.Key))
            {
                var p = Properties.FirstOrDefault(x => x.Name == property.Key);

                if (p != null)
                    p.Value = property.Value.NormalisedValue;
                else
                {
                    Properties.Add(new PropertyListItemViewModel
                    {
                        Name = property.Key,
                        Value = property.Value.NormalisedValue
                    });
                }
            }
        }
    }
}
