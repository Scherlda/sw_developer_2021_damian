using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatypes_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datentyp Varialbenbezeichnung
            int eineZahl; //Deklaration
            eineZahl = 5; //Initialisierung

            Console.WriteLine(eineZahl);
            Console.WriteLine("int-Max: " + int.MinValue);
            Console.WriteLine("int-Max: " + int.MaxValue);

            //Datentyp Varialbenbezeichnung
            //Deklaration & Initialisierung
            string name = "Gandalf";
            Console.WriteLine(name);
            Console.WriteLine("Anzahl der Zeiche: " + name.Length);

            double gewicht = 0.45;
            Console.WriteLine("Das Gewicht ist: " + gewicht);

            decimal meinBudget = 455.3215m;
            Console.WriteLine(meinBudget);

            bool isPowerOn = true;


        }
    }
}
