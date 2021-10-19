using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GL_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl = 4;

            //Ist der Wert bereits erfüllt do wird es nicht ausgeführt
            while(zahl < DateTime.Now.Second)
            {
                Console.WriteLine(DateTime.Now.Second);
                Thread.Sleep(1000);
            }

            //Wird zuerst ausgeführt und erst dann wird geprüft ob der Wert erfüllt ist.
            do
            {
                Console.WriteLine($"do-while: {DateTime.Now.Second}");
                Thread.Sleep(1000);

            } while (zahl < DateTime.Now.Second);


        }
    }
}
