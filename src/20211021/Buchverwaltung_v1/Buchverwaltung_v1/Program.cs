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
           *     Buch nach der Eingabe automatisch abgespeichert wird. (Gibt es das Buch bereits, soll die Datei )
           *  
           */

            while (true)
            {
                MyTools.ConsoleTools.UIHelper.PrintHeader("Buchverwaltung");
                BookInfos.ReadBookInfos();

                Console.ReadKey();
                Console.Clear();
            }

            

        }

        
    }
}
