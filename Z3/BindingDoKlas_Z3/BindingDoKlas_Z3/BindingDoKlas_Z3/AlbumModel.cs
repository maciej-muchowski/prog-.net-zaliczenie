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
            Albums.Add(new Album("Appettite for Destruction", "Guns N' Roses", "Geffen Records", "CD", new DateTime(year: 1987, month: 7, day: 21)));
        }
    }
}
