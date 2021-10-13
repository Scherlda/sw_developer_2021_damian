using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen_Datentypen_rechnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double zahl1;
            double zahl2;
          //  double zahl3;

            Console.Write("Bitte gib deine erste Zahl ein: ");
            zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nBitte gib deine zweite Zahl ein: ");
            zahl2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Verschiedene Rechenbeispiele
            Console.WriteLine("{0} + {1} = {2}", zahl1, zahl2, zahl1 + zahl2);
            Console.WriteLine("{0} - {1} = {2}", zahl1, zahl2, zahl1 - zahl2);
            Console.WriteLine("{0} * {1} = {2}", zahl1, zahl2, zahl1 * zahl2);
            Console.WriteLine("{0} / {1} = {2}", zahl1, zahl2, zahl1 / zahl2);
            
            //Wenn zahl1 > zahl2 = 1
            //Wenn zahl1 < zahl1 = -1
            //Wenn zahl1 = zahl2 = 0
            Console.WriteLine("Zahl1 ist größer(1), kleiner (2) oder gleich (0) zu Zahl2: {0}", zahl1.CompareTo(zahl2));
            //entspricht zahl1, zahl2, dann true, sonst false
            Console.WriteLine("Zahl1 und Zahl2 sind ident: {0}", zahl1.Equals(zahl2));

            //Math Klasse
            //Gibt die höhere Zahl aus
            Console.WriteLine(Math.Max(zahl1, zahl2));
            Console.WriteLine(Math.Ceiling(zahl1));

            Console.ReadKey();

        }
    }
}
