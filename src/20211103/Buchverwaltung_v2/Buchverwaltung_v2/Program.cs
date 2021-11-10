using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MyTools.ConsoleTools;

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

                            ReadBookData();


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
                    CheckUserInput.FalseInputTimerAndRepositionCourser(positionLeft, positionTop, 2000, "Es wurde nicht 1, 2 oder 3 eingegeben");
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
            newBook.Erscheinungsjahr = CheckYearLenght(35, 8);
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("Preis:");
            newBook.Preis = MyTools.ConsoleTools.CheckUserInput.Double_CheckInputAndRepositionMouse(25, 9, 2000);
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Isbn:");
            newBook.Isbn = 000;

        }

        static int CheckYearLenght(int mousePositionLeft, int mousePositionTop)
        {
            int userInput = 2000;
            
           // bool userInputIsOk = false;
            bool userInpoutCorrectFormat = false;
            do
            {
                
                userInput = CheckUserInput.Int_CheckInputAndRepositionMouse(mousePositionLeft, mousePositionTop, 2000);
                 

                if (userInput > ((Convert.ToInt32(DateTime.Now.Year) + 2)) && (userInput < ((Convert.ToInt32(DateTime.Now.Year) - 4000))))
                {
                    CheckUserInput.FalseInputTimerAndRepositionCourser(mousePositionLeft, mousePositionTop, 2000, "Das Datum lag nicht im gültigen Bereich!");
                    userInpoutCorrectFormat = false;
                }
                else
                {
                    userInpoutCorrectFormat = true;
                }
            }
            while (!userInpoutCorrectFormat);
            return userInput;
        }

        
    }
}
