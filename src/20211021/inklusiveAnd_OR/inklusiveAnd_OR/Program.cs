using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inklusiveAnd_OR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Werttypen, int, double, bool, ...
            string name1 = "Gandalf"; //string ist eine art zwitter, dieser kann sowohl ein Werttyp als auch ein Referenztyp sein
            string name2 = null; //Referenztyp
            int charCount = 0;

            /*
             * Und = &
             * Einfaches und oder sollte nur verwendet werden wenn es wirklihc gebraucht wird.
             * sollen mehrere Werte grpüft werden in einer if abfrage so kann mit & oder | (oder) mehrfaches geprüft werden.
             * ein einfaches & könnte benötigt werden kann man prüfen will ob eine Datenbank connectet und Available ist. (beides wird geprüft, wenn das erste nicht Zutrift wird das zweite nicht geprüft)
             * Exklusiv und = &&
             * Ist der erste Wert bei "if (name2 != null & name1 != null)" name2 schon nicht zutrifft dann wird der zweite Wert nicht geprüft, das macht den Code perfomanter. 
             */

            //Hier macht && sinn da wenn die zweite bedingung geprüft würden werde eine Exception ausgelöst werden würde, durch && stimmt das erste schon nicht und der zweite Wert wird nicht geprüft
            if (name1 != null && name1.Length > 50)
            {
                charCount = name1.Length + name2.Length;
                Console.WriteLine($"Gessamtanzahl der Buchstaben: {charCount}");
            }

            //Metriken: https://docs.microsoft.com/en-us/cpp/c-language/precedence-and-order-of-evaluation?view=msvc-160



        }
    }
}
