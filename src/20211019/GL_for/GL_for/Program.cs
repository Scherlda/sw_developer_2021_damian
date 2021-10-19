using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GL_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for wird verwendet wenn die Anzahl der Wiederholungen bekannt ist
            //Initioalisierung; Abbruchbedingung; Reinitialisierung
             for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ausgabe mit {i}");
            }
        }
    }
}
