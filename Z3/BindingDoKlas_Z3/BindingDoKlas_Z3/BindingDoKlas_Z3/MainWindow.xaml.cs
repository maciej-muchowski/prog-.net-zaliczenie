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

namespace BindingDoKlas_Z3
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AlbumModel albumModel = new AlbumModel();
        public MainWindow()
        {
            DataContext = albumModel;
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            new AlbumView(albumModel.NewAlbum()).ShowDialog();
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            ListBox list = (ListBox)this.FindName("Albums");
            Album chosen = (Album)list.SelectedItem;

            if (chosen != null)
                new AlbumView(chosen).ShowDialog();
        }
    }
}
