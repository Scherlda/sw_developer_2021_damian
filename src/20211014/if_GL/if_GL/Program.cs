using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl_1 = 5;
            int zahl_2 = 8;

            if(zahl_1 > zahl_2)
            {
                Console.WriteLine("Zahl 1 ist größer");
            }

            if (zahl_1 > 10 & DateTime.Now.Day == 14)
            {
                Console.WriteLine("Ein schöner Tag!");
            }

        }
    }
}
