using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatoren_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithemtische Operatoren
            //+ - * /
            // % = Restwertdivision (Modulo)
            int z1 = 0;
            int z2 = 0;
            int z3 = 0;

            //z3 = z1 + 654.22;

            //vergleichs-Operatoren
            // < > >= <=
            // == !=
            bool erg = false;
            erg = z2 == z1;

            //Binäre Operatoren
            //&& | && || !

            //Zusammengesetzte Operatoren
            int eineZahl = 5;
            eineZahl = eineZahl + 5;
            //Kurzform
            eineZahl += 5;
            eineZahl -= 8;
            eineZahl *= 2;
            eineZahl /= 3;
            //inkrementieren
            eineZahl++;
            //dekrementieren
            eineZahl--;




        }
    }
}
