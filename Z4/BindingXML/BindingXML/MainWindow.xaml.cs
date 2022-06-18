using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BindingXML
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CategoryModel categoryModel = CategoryModel.GetCategoryModel();
        public MainWindow()
        {
            DataContext = categoryModel;
            InitializeComponent();
        }
        /*private void OpenSubcategory(object sender, RoutedEventArgs e)
        {
            new Subcategory(subModel.GetCategory(((Button)sender).Name)).ShowDialog();
        }*/

        private void ShowCategory(object sender, RoutedEventArgs e)
        {
            ListBox list = (ListBox)this.FindName("Categories");
            Category chosen = (Category)list.SelectedItem;

            if (chosen != null)
                new CategoryView(chosen).Show();
        }
    }
}
