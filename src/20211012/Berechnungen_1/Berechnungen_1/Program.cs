using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berechnungen_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int laenge = 3;
            int breite = 5;
            int umfang = 0;

            //Berechnung des umfangs
            umfang = (laenge + breite) * 2;
            

            //Ausgabe der Ergebnisse
            Console.WriteLine("Der Umfang beträgt: {0}", umfang);
        }
    }
}
