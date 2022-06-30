﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace BindingXML
{
    /// <summary>
    /// Logika interakcji dla klasy TypeView.xaml
    /// </summary>
    public partial class TypeView : Window
    {
        public TypeView(System.Xml.XmlElement type)
        {
            DataContext = type;
            InitializeComponent();
        }

        private void ShowModels(object sender, RoutedEventArgs e)
        {
            FrameworkElement parent = (FrameworkElement)((FrameworkElement)sender).Parent;
            ListBox list = (ListBox)parent.FindName("Manufacturer");
            new ManufacturerView((System.Xml.XmlElement)list.SelectedItem).Show();
        }
    }
}
