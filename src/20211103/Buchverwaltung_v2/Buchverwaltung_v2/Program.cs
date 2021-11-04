using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Buchverwaltung_v2
{
    struct Buch
    {
        public string Titel;
        public string Author;
        public string Kategorie;
        public int Seitenanzahl;
        public int Erscheinungsjahr;
        public double Preis;
        public int Isbn;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            {
                switch (NewOrListBook())
                {
                    case 1: //Liest Buchdaten ein
                        {
                            Console.Clear();
                            MyTools.ConsoleTools.UIHelper.PrintHeader("Buchverwaltung");

                            Buch newBook = new Buch();
                            Console.SetCursorPosition(10, 4);
                            Console.WriteLine("Titel:");
                            newBook.Titel = MyTools.ConsoleTools.CheckUserInput.String_CheckInputEmptyAndRepositionMouse(25,4,2000);
                            newBook.Author = Console.ReadLine();


                            break;
                        }
                    case 2: //Gibt alle eingelesenen Bücher aus
                        {
                            break;
                        }
                    case 3: //Beendet das Program
                        {
                            runProgram = false;
                            break;
                        }

                }
                
            } while (runProgram);
            


        }


        static int NewOrListBook()
        {
            Console.Clear();
            MyTools.ConsoleTools.UIHelper.PrintHeader("Buchverwaltung");
            Console.Write("Möchten Sie ein neuen Buch anlegen oder die bestehenden aufgelistet bekommen?\n1 für neues Buch\n2 für bestehende auflisten\n3 um das Program zu verlassen\n");
            string userSelection = String.Empty;
            int positionLeft = 0;
            int positionTop = 7;
            int timeForSleep = 2000;
            bool userInputIsCorrect = false;

           do
            {
                userSelection = Console.ReadLine();

                if (userSelection == "1")
                {
                    userInputIsCorrect = true;
                }
                else if(userSelection == "2")
                {
                    userInputIsCorrect = true;
                }
                else if (userSelection == "3")
                {
                    userInputIsCorrect = true;
                }
                else
                {
                    int waitTimeNewInput = timeForSleep;
                    do
                    {
                        Console.SetCursorPosition(positionLeft, positionTop);
                        Console.Write($"Es wurde nicht 1 oder 2 eingegeben Versuche es erneut in {waitTimeNewInput.ToString().Trim('0')} Sekunden");
                        Thread.Sleep(1000);
                        waitTimeNewInput -= 1000;
                    } while (waitTimeNewInput > 0);

                    Console.SetCursorPosition(positionLeft, positionTop);
                    Console.Write(new string(' ', Console.WindowWidth - (positionLeft - 1)));
                    Console.SetCursorPosition(positionLeft, positionTop);
                    userInputIsCorrect = false;
                }
            }
           while (!userInputIsCorrect);
            return Convert.ToInt32(userSelection);

        }
        

        static void ReadBookData()
        {
            Console.Clear();
            MyTools.ConsoleTools.UIHelper.PrintHeader("Buchverwaltung");

            Buch newBook = new Buch();
            Console.SetCursorPosition(10, 4);
            Console.WriteLine("Titel:");
            newBook.Titel = MyTools.ConsoleTools.CheckUserInput.String_CheckInputEmptyAndRepositionMouse(25, 4, 2000);
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Auhor:");
            newBook.Author = MyTools.ConsoleTools.CheckUserInput.String_CheckInputEmptyAndRepositionMouse(25, 5, 2000);
            Console.SetCursorPosition(10, 6);
            Console.WriteLine("Kategorie:");
            newBook.Kategorie = MyTools.ConsoleTools.CheckUserInput.String_CheckInputEmptyAndRepositionMouse(25, 6, 2000);
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Seitenanzahl:");
            newBook.Seitenanzahl = MyTools.ConsoleTools.CheckUserInput.Int_CheckInputAndRepositionMouse(25, 7, 2000);
            Console.SetCursorPosition(10, 8);
            Console.WriteLine("Erscheinungsjahr (yyyy):");
            newBook.Erscheinungsjahr = ;
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("Preis:");
            newBook.Preis = MyTools.ConsoleTools.CheckUserInput.Double_CheckInputAndRepositionMouse(25, 9, 2000);
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Isbn:");
            newBook.Isbn = 000;

        }

        static int CheckYearLenght()
        {
            int userInput = 2000;
            
            bool userInputIsOk = false;
            bool userInpoutCorrectFormat = false;
            do
            {
                do
                {
                    try
                    {
                        userInput = int.Parse(Console.ReadLine());
                        userInputIsOk = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Es wurde keine Zahl eingeben!");
                        userInputIsOk = false;
                    }
                }while (!userInputIsOk);

                if (userInput > (DateTime.Now.Year + 2) && (userInput < DateTime.Now.Year - )
                {
                    Console.WriteLine("Die Eingbe ist ungültig! Bitte gib eine neue Zahl ein!");
                    userInpoutCorrectFormat = false;
                }
            }
            while (!userInpoutCorrectFormat);

        }

        
    }
}
