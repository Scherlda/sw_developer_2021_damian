using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechtecksberechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Aufgabe
             *   Schreiben Sie eine Applikation, mit der der Umfang eines beliebigen Rechtecks berechnet werden kann.
             *   Dazu soll die Applikation die Seitenlänge vom User einlesen und anschliessend den Umfang berechnen
             *   Ausgabe Ergebnis (Umfang) inklusive den Seitenlängen, schön formatiert           
             */

            //Variablen
            string aEingabe = string.Empty;
            int a = 0;
            string bEingabe = string.Empty;
            int b = 0;
            int u = 0;

            //User Ineraktion
            Console.WriteLine("Hallo, mit diesem Konsolen Programm kannst du den Umfang eines Rechtecks berechnen");

            Console.Write("Bitte gib die Seite a ein: ");
            aEingabe = Console.ReadLine();
          
            Console.Write("Bitte gib die Seite b ein: ");
            bEingabe = Console.ReadLine();

            //Konvertierung + Berechnung des Rechecks
            a = int.Parse(aEingabe);
            b = int.Parse(bEingabe);
            u = 2*(a+b);

            //Ausgabe
            Console.Clear();
            Console.Write("Die Seitenlänge a ist: {0}\nDie Seitenlänge b ist: {1}\n\n", a, b);
            Console.Write("Umgabeberechnung: u = 2 * (a + b)\n\nDer Umfang ist: {0}\n", u);


        }
    }
}
