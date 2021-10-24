using System;
using System.Threading;
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
        //private static string UserInput;
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
            SetBookNumberPages();

        }

        public static void SetBookTitel()
        {
            Console.SetCursorPosition(30, 7);
            BookTitel = Console.ReadLine();
        }
        public static void SetBookAuthor()
        {
            Console.SetCursorPosition(30, 8);
            BookAuthor = Console.ReadLine();
        }

        public static void SetBookNumberPages()
        {
            do
            {
                int waitTimeNewInput = 3000;
                Console.SetCursorPosition(30, 9);
                //string UserInput = Console.ReadLine();

                while (!int.TryParse(Console.ReadLine(), out int BookNumberPages))
                {
                    
                    do
                    {
                        Console.SetCursorPosition(30, 9);
                        Console.Write($"Es sind nur Zahlen erlaubt! Versuche es erneut in {waitTimeNewInput.ToString().Trim('0')} Sekunden"); 
                        Thread.Sleep(1000);
                        waitTimeNewInput -= 1000;
                    } while (waitTimeNewInput > 0);
                    
                    waitTimeNewInput = 3000;
                    Console.SetCursorPosition(30, 9);
                    Console.Write(new string(' ', Console.WindowWidth - 31));
                    Console.SetCursorPosition(30, 9);
                    
                }

            } while (IsUserInputCorrect == false);
            
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
