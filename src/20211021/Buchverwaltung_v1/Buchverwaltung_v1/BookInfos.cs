using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Buchverwaltung_v1
{
    internal class BookInfos
    {
        //Attributes from Book
        public static string BookTitel;
        public static string BookAuthor;
        public static int BookNumberPages; //How many Sites are in the Book
        public static DateTime BookYearOfPublication;
        public static double BookPrice;
        public static string CustomerIBAN;
       
       
        public static void ReadBookInfos()
        {
            string yearClibboard = string.Empty;

            //User interaction
            //Noch einen Rahmen Zeichen?
            
            Console.WriteLine("\n\nBitte geben Sie folgende Daten für die Buchanlage ein:\n");
            Console.WriteLine("\tTitel: ");
            Console.WriteLine("\tAuthor: ");
            Console.WriteLine("\tAnzahl der Seiten: ");
            Console.WriteLine("\tErscheinungsjahr: ");
            Console.WriteLine("\tPreis (xx,yy): ");
            Console.WriteLine("\tKunde-IBAN: ");

            //Fill all attribute variables
            SetBookTitel();
            SetBookAuthor();
            SetBookNumberPages();
            SetBookYearOfPublication();
            SetBookPrice();
            SetCustomerIBAN();
        }

        public static void SetBookTitel()
        {
            BookTitel = MyTools.ConsoleTools.CheckUserInput.String_CheckInputEmptyAndRepositionMouse(30, 7, 2000);
            
        }
        public static void SetBookAuthor()
        {
            //Console.SetCursorPosition(30, 8);
            BookAuthor = MyTools.ConsoleTools.CheckUserInput.String_CheckInputEmptyAndRepositionMouse(30, 8, 2000);
        }

        public static void SetBookNumberPages()
        {
            BookNumberPages = MyTools.ConsoleTools.CheckUserInput.Int_CheckInputAndRepositionMouse(30, 9, 2000); //Position von links, von oben und Timer wie lange eine Meldung angezeigt werden soll.
        }
        public static void SetBookYearOfPublication()
        {
            BookInfos.BookYearOfPublication = MyTools.ConsoleTools.CheckUserInput.DateYear_CheckInputAndRepositionMouse(30, 10, 2000);
        }
        public static void SetBookPrice()
        {
            Console.SetCursorPosition(30, 11);
            BookPrice = MyTools.ConsoleTools.CheckUserInput.Double_CheckInputAndRepositionMouse(30, 11, 2000);
        }
        public static void SetCustomerIBAN()
        {
            bool ibanIsOk = false;
            int positionLeft = 30;
            int positionTop = 12;
            int timeForSleep = 2000;
            int waitTimeNewInput = timeForSleep;

            do
            {
                
                Console.SetCursorPosition(positionLeft, positionTop);
                Console.Write("XXzzzzzzzzzzzzzzzzzz");
                Console.SetCursorPosition(positionLeft, positionTop);
                CustomerIBAN = Console.ReadLine();

                //Überprüft op der IBAN Korrekt eingegeben wurde
                ibanIsOk = Regex.IsMatch(CustomerIBAN, @"[a-zA-Z]{2}[0-9]{2}[a-zA-Z0-9]{4}[0-9]{7}([a-zA-Z0-9]?){0,16}");
                
                if (!ibanIsOk)
                {
                    do
                    {
                        Console.SetCursorPosition(positionLeft, positionTop);
                        Console.Write($"format stimmt nicht mit dem IBAN überein! Versuche es erneut in {waitTimeNewInput.ToString().Trim('0')} Sekunden");
                        Thread.Sleep(1000);
                        waitTimeNewInput -= 1000;
                    } while (waitTimeNewInput > 0);

                    waitTimeNewInput = timeForSleep;
                    Console.SetCursorPosition(positionLeft, positionTop);
                    Console.Write(new string(' ', Console.WindowWidth - (30 - 1)));
                    Console.SetCursorPosition(positionLeft, positionTop);
                }
                
            } while (!ibanIsOk);
        }

        

    }
}
