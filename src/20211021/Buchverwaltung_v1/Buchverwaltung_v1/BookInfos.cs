using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchverwaltung_v1
{
    internal class BookInfos
    {
        public static string BookTitel;
        public static string BookAuthor;
        public static string BookNumberPages; //How many Sites are in the Book
        public static string BookYearOfPublication;
        public static string BookPrice;
        public static string CustomerIBAN;
        public static void ReadBookInfos()
        {
            Console.WriteLine("\n\nBitte geben Sie folgende Daten für die Buchanlage ein:\n");
            Console.WriteLine("\tTitel: ");
            Console.WriteLine("\tAuthor: ");
            Console.WriteLine("\tAnzahl der Seiten: ");
            Console.WriteLine("\tErscheinungsjahr: ");
            Console.WriteLine("\tPreis: ");
            Console.WriteLine("\tKunde-IBAN: ");
        }
    }
}
