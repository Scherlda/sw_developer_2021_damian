using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int geburtsJahr;

            //Deklaration
            int[] listeVonGeburtsjahren; //Das ist eine Lite von int, das ist ein Datentyp

            //Dimensionierung
            listeVonGeburtsjahren = new int[10];

            //Initialisierung
            listeVonGeburtsjahren[0] = 5;
            //Oder
            for (int i = 0; i < listeVonGeburtsjahren.Length; i++)
            {
                listeVonGeburtsjahren[i] = 5;
            }

            listeVonGeburtsjahren = new int[21]; //durch new wird jetzt ein neuer Array erzeugt, die vorher gespeichterten Daten werden geleert.

            Console.WriteLine(listeVonGeburtsjahren[2]);
        }
    }
}
