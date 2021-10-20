using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenBeispiel_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Entwickeln Sie eine kleiner Personalveraltung für ihr Unternehmen!
             * Folgende Daten pro Mitarbeiter sollen eingelesen werden:
             * 
             * - Vorname
             * - Nachname
             * - Geburtsdatum
             * - Sozialversicherungsnummer
             * 
             * Dabei gilt:
             * - Realisieren Sie für alle Eingaben eine fehlertolerante Versiante (Keine Exceptions, Fehleingaben beenden die Applikation)
             * - Eingaben sollen wie ein Formular gestaltet werden. d.h. USer sieht im alle einzugebenden
             *   Felder im Voraus.
             * - Alle Daten sollen am Schluss formatiert ausgegeben werden.
             *  
             *  Screenmockup:
             *  
             *  ############################################################
             *                    Personalverwaltung v0.1
             *  ############################################################
             *  
             *  Bitte geben Sie ein:
             *  
             *          Vorname: _
             *         Nachname:
             *     Geburtsdatum:
             *      Sozialv.Nr.:
             *      
             * Hints:
             * Console.Clear();
             * Console.SetCursorPosition(x, y) Oder Console.Cursereft = 15;
             * 
             * 
             * Screenmockup Ausgabe:
             * 
             *                
             *  ############################################################
             *                    Personalverwaltung v0.1
             *  ############################################################
             *  
             * Gandalf DERWEISE
             * 15.04.1915
             * 1234 15041915
             */

            string userVorname = string.Empty;
            string userNachname = string.Empty;
            DateTime userGeburtstag = DateTime.Now;
            int SozialvNummer = 0;
            const string header = "Personalverwaltung v0.1";
            int xPos = 0;
            bool isInputValid = false;


            //Formular
            Console.Clear();
            Console.WriteLine(new string('#', Console.WindowWidth-1 )); //Erzeugt so lange wie das Fenster ist, ein bestimmtes Zeichen.
            xPos = Console.WindowWidth / 2 - header.Length / 2; //Postionierung der des headers in der Mitte
            Console.CursorLeft = xPos;
            Console.WriteLine(header);
            Console.WriteLine(new string('#', Console.WindowWidth - 1));
            Console.WriteLine("Bitte geben Sie ein: \n");
            Console.WriteLine("\t     Vorname: ");
            Console.WriteLine("\t    Nachname: ");
            Console.WriteLine("\tGeburtsdatum: ");
            Console.WriteLine("\t Sozialv.Nr.: ");
            
            //Read User imput
            Console.SetCursorPosition(22, 5);
            userVorname = Console.ReadLine();
            Console.SetCursorPosition(22, 6);
            userNachname = Console.ReadLine();
            

            try
            {
                Console.SetCursorPosition(22, 7);
                userGeburtstag = DateTime.Parse(Console.ReadLine());

                Console.SetCursorPosition(22, 8);
                SozialvNummer = int.Parse(Console.ReadLine());
                isInputValid = true;
            }
            catch (Exception)
            {
                Console.WriteLine("\aERROR: Leider fehlerhafte Eingabe entdeckt. Versuchen Sie es nochmal!");
                isInputValid = false;
            }

            if (!isInputValid) //Wenn isInputValid = false dann return. Damit der darunterstehende Code nicht ausgeführt wird. return beendet jetzt das Programm
            {
                return;
            }

            //Output
            Console.Clear();
            Console.WriteLine(new string('#', Console.WindowWidth - 1)); //Erzeugt so lange wie das Fenster ist, ein bestimmtes Zeichen.
            xPos = Console.WindowWidth / 2 - header.Length / 2; //Postionierung der des headers in der Mitte
            Console.CursorLeft = xPos;
            Console.WriteLine(header);
            Console.WriteLine(new string('#', Console.WindowWidth - 1));

            Console.WriteLine($"\n{userVorname} {userNachname.ToUpper()}"); //Mit dem Dollar wird der String unterbrochen und so kann in der geschwungenen Klammer direkt die Variable eingefügt werden.
            Console.WriteLine("\tGeburtsdatum: {0}", userGeburtstag.ToShortDateString());
            //Verschiedene Ausgaben
            Console.WriteLine("\t Sozialv.Nr.: {0}{1}{2}{3}", SozialvNummer, userGeburtstag.Day, userGeburtstag.Month, userGeburtstag.Year);
            Console.WriteLine($"{SozialvNummer} {userGeburtstag.Day}{userGeburtstag.Month}{userGeburtstag.Year}");
            Console.WriteLine($"{SozialvNummer} {userGeburtstag.ToString("ddMMyy")}"); //DateTime in einen String mit bestimmter Formatierung Convertieren durch die c""
            
            string textzahl = "123";
            int zahl = int.Parse(textzahl);

        }
    }
}
