using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchverwaltung_v1
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
           * Die Applikation soll Buchdatn erfassen.
           * Folgende Daten sollen dabei berücksichtigt werden:
           * 
           *  - Titel
           *  - Autor
           *  - Kategorie
           *  - Seitenanzahl
           *  - Erscheinungsjahr
           *  - Preis
           *  - IBAN
           *  
           *  Dabei gilt:
           *  
           *  1. Verwende und schreibe Methoden!
           *  2. Realisiere fehlertolerante Eingaben!
           *  
           *  3. Perisistiere (heisst speichern) die Buchdaten in einer Datei, welhe so heisst wie der Titel
           *     Bsp. Buch Titel = "Die unendliche Geschichte" => DieunendlicheGeschichte.book
           *  
           *  4. Bauae das Program so um, dass der User beliebig viele Bücher eingeben kann und jedes 
           *     Buch nach der Eingabe automatisch abgespeichert wird. (Gibt es das Buch bereits, soll die Datei ersetzt werden)
           *  
           */

            

            do
            {
                bool inputIsCorrect = false;
                bool userInputWasCorrect = false;
                do
                {

                    Console.Clear();
                    MyTools.ConsoleTools.UIHelper.PrintHeader("Buchverwaltung");
                    BookInfos.ReadBookInfos();
                    

                    //User soll Seine Eingaben prüfen
                    do
                    {
                        Console.WriteLine("\nSind Sie mit den Eingaben zufrieden oder möchten Sie alle Eingaben leeren?\n1 für zufrieden\n2 für alles leeren");
                        string userInput = Console.ReadLine();
                        if (userInput == "1")
                        {
                            inputIsCorrect = true;
                            userInputWasCorrect = true;
                        }
                        else if (userInput == "2")
                        {
                            inputIsCorrect = false;
                            userInputWasCorrect = true;
                        }
                        else
                        {
                            Console.WriteLine("Die Eingabe war ungültig");
                            userInputWasCorrect= false;
                        }

                    } while (userInputWasCorrect == false);

                    //Wenn alle Eingaben gepasst haben, wird das Buchgespeichert
                    if (inputIsCorrect)
                    {
                        BookToFile.EveryBookToOwnFile();
                    }
                    

                } while (inputIsCorrect == false);
                
                

                Console.WriteLine("\nDas Buch wurde gespeichert. Betätigen Sie eine beliebige Taste um ein weiteres Buch anzulegen");
                Console.ReadKey();
                

            }while(true);

            

        }

        
    }
}
