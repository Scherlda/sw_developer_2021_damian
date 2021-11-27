using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    public class Book : IBook
    {
        private string _title;
        private string _autor;
        private string _publisher;
        private int _ageRating;
        private string _languages;
        private int _yearOfPublicaion;

        public Book()
        {
        }

        public Book(string title, string autor, string publisher, int ageRating, string languages, int yearOfPublication)
        {
            _title = title;
            _autor = autor;
            _publisher = publisher;
            _ageRating = ageRating;
            _languages = languages;
            _yearOfPublicaion = yearOfPublication;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }
        public int AgeRating
        {
            get { return _ageRating; }
            set { _ageRating = value; }
        }
        public string Languages
        {
            get { return _languages; }
            set { _languages = value; }
        }
        public int YearOfPublication
        {
            get { return _yearOfPublicaion; }
            set { _yearOfPublicaion = value; }
        }

      
    }
}
