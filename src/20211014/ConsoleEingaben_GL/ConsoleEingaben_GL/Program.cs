using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEingaben_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Elegantere Lösung um den string leer zu lassen. Ist etwas mehr Speicheroptimiert.
            string name = string.Empty;
            string geburtsJahrEingabe = string.Empty;
            int geburtsJahr = 0;
            int alter = 0;
            bool eingabePasst = false;

            Console.Write("Bitte Name eingeben: ");
            name = Console.ReadLine();

            Console.Write("\nHallo {0}, wie geht's\n", name);
           
            Console.Write("{0}, bitte gib dein Geburtsjahr ein: ", name);
            geburtsJahrEingabe = Console.ReadLine();            

            //Konvertierung Zeichenkette nach int
            geburtsJahr = int.Parse(geburtsJahrEingabe);

            //Alter von User berechnen
            alter = DateTime.Now.Year - geburtsJahr;

            Console.WriteLine("{0}, du bist {1} Jahre alt.",name, alter);

        }
    }
}
