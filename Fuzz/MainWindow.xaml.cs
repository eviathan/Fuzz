﻿using Fuzz.ViewModels;
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
        public MainWindowViewModel Model { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Model = new MainWindowViewModel(new Theme());
            DataContext = Model;
        }

        private void MenuItem_Open(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Ableton skin files (*.ask)|*.ask"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                Model.Set(Theme.Parse(File.ReadAllText(openFileDialog.FileName)));
            }
        }

        private void MenuItem_Save(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Ableton skin files (*.ask)|*.ask"
            };
            //if(saveFileDialog.ShowDialog() == true) File.
        }
    }
}
