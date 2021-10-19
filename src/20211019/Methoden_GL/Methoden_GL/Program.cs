using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrinterHelloWorld();

            string name = "Gandalf";

            PrintMessage(name);
            PrintMessage(Console.ReadLine());
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        //Signatur
        //RückgabeTyp MethodenBezeichnung(Parameter)
        static void PrinterHelloWorld()
        {
            Console.WriteLine("Hello World");
        }

    }
}
