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
        public static DateTime BookYearOfPublication;
        public static string BookPrice;
        public static string CustomerIBAN;
        private static bool IsUserInputCorrect = false;
        public static void ReadBookInfos()
        {
            string yearClibboard = string.Empty;
            //User interaktion
    //Noch einen Rahmen Zeichen?
            Console.WriteLine("\n\nBitte geben Sie folgende Daten für die Buchanlage ein:\n");
            Console.WriteLine("\tTitel: ");
            Console.WriteLine("\tAuthor: ");
            Console.WriteLine("\tAnzahl der Seiten: ");
            Console.WriteLine("\tErscheinungsjahr: ");
            Console.WriteLine("\tPreis: ");
            Console.WriteLine("\tKunde-IBAN: ");

        }

        public static void SetBookTitel()
        {
            do
            {
                Console.SetCursorPosition(30, 7);
            } while (IsUserInputCorrect == false);
            

            BookTitel = Console.ReadLine();
        }
        public static void SetBookAuthor()
        {
            Console.SetCursorPosition(30, 8);
            BookAuthor = Console.ReadLine();
        }

        public static void SetBookNumberPages()
        {
            Console.SetCursorPosition(30, 9);
            BookNumberPages = Console.ReadLine();
        }
        public static void SetBookYearOfPublication()
        {
            string yearClibboard = string.Empty;
            Console.SetCursorPosition(30, 10);
            yearClibboard = Console.ReadLine();
        }
        public static void SetBookPrice()
        {
            Console.SetCursorPosition(30, 11);
            BookPrice = Console.ReadLine();
        }
        public static void SetCustomerIBAN()
        {
            Console.SetCursorPosition(30, 12);
            CustomerIBAN = Console.ReadLine();
        }

    }
}
