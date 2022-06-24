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

namespace BindingDoKlas_Z3
{
    /// <summary>
    /// Logika interakcji dla klasy AlbumView.xaml
    /// </summary>
    public partial class AlbumView : Window
    {
        public AlbumView(Album album)
        {
            DataContext = album;
            InitializeComponent();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
