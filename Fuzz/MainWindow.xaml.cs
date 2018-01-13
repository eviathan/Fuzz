using Fuzz.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fuzz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string WINDOW_TITLE = "Fuzz";

        public MainWindowViewModel Model { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Model = new MainWindowViewModel(new Theme());
            DataContext = Model;
        }

        private void MenuItem_Open(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "Ableton skin files (*.ask)|*.ask"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                OpenFile(openFileDialog.FileName, openFileDialog.SafeFileName);
            }
        }

        private void OpenFile(string filePath, string fileName)
        {
            Model.WindowTitle = $"{WINDOW_TITLE} - {fileName}";
            Model.Set(Theme.Parse(File.ReadAllText(filePath)));
        }

        private void MenuItem_Save(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new Microsoft.Win32.SaveFileDialog
            {
                Filter = "Ableton skin files (*.ask)|*.ask"
            };

            if(saveFileDialog.ShowDialog() == true)
            {
                var filePath = saveFileDialog.FileName;
                var themeString = Theme.Serialize(new Theme(Model));
                File.WriteAllText(filePath, themeString);
                OpenFile(saveFileDialog.FileName, saveFileDialog.SafeFileName);
            }
        }
    }
}
