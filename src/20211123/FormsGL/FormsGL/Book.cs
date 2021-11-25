using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FormsGL
{
    public class Book : IBook
    {

        public Book() { }

        public Book(string title, string author, string publisher, DateTime yearOfPublishing)
        {
            Titel = title;
            Author = author;
            Publisher = publisher;
            YearOfPublication = yearOfPublishing;
        }



        public string _titel;
        public string _author;
        public string _publisher;
        public DateTime _yearOfPublication;

        public string Titel

        {
            get { return _titel; }
            set { _titel = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public DateTime YearOfPublication
        {
            get { return _yearOfPublication; }
            set { _yearOfPublication = value; }
        }
    }
}
