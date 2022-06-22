using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingDoKlas_Z3
{
    public class Album
    {
        private string title;
        private string author;
        private string publisher;
        private string medium;
        private DateTime releaseDate;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Medium { get => medium; set => medium = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }

        public Album(string title, string author, string publisher, string medium, DateTime releaseDate)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.medium = medium;
            this.releaseDate = releaseDate;
        }
    }
}
