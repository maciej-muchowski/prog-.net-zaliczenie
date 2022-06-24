using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingDoKlas_Z3
{
    internal class AlbumModel
    {
        public ObservableCollection<Album> Albums { get; } = new ObservableCollection<Album>();

        public AlbumModel()
        {
            Albums.Add(new Album("Appetite for Destruction", "Guns N' Roses", "Geffen Records", "CD", new DateTime(year: 1987, month: 7, day: 21)));
            Albums.Add(new Album("The Black Album", "Metallica", "Elektra", "CD", new DateTime(year: 1991, month: 8, day: 12)));
            Albums.Add(new Album("Hipertrofia", "Coma", "Sony BMG Music Entertainment Poland", "CD", new DateTime(year: 2008, month: 11, day: 10)));
        }

        internal Album NewAlbum()
        {
            Album album = new Album();
            Albums.Add(album);
            
            return album;
        }
    }
}
