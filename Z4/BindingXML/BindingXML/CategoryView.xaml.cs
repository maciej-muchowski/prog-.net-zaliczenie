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
using System.Windows.Shapes;

namespace BindingXML
{
    /// <summary>
    /// Logika interakcji dla klasy CategoryView.xaml
    /// </summary>
    public partial class CategoryView : Window
    {
        public CategoryView(Category category)
        {
            DataContext = category;
            InitializeComponent();
        }

        private void ShowSubcategory(object sender, RoutedEventArgs e)
        {
            ListBox list = (ListBox)this.FindName("Subcategories");
            Subcategory chosen = (Subcategory)list.SelectedItem;

            if (chosen != null)
                new SubcategoryView(chosen).Show();
        }
    }
}
