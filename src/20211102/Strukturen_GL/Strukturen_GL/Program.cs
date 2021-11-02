using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukturen_GL
{
    struct Book //Ist eine Struktur, keine Klasse. Strukturen sind keine Klassen, Strukturen kommen noch aus der c Zeit. alle Daten landen im Stack Speicher
    {
        public string Title;
        public string Author;
        public string Isbn;
        public decimal Price;
        public int PublishYear;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklaration
            Book myBook;

            //Erzeugung
            myBook = new Book();

            Book myOtherBook = new Book();

            myOtherBook.Title = "TestTitel";
            myOtherBook.PublishYear = 1988;

            DisplayBook(myOtherBook);
            DisplayBook(myBook);

            //Professioneller Weg
            myBook = ReadBookData();
            
            ConsoleKeyInfo keyInfo = Console.ReadKey(); //???

        }

        static void DisplayBook (Book bookToDisplay)
        {
            Console.WriteLine(bookToDisplay.Title);
        }

        static Book ReadBookData()
        {
            Book aNewBook = new Book();
            //eingeben blabla...

            return aNewBook;
        }
    }
}
