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
            PrintColorMessage("PAUSE!\n", ConsoleColor.Yellow);
        }

        static void PrintColorMessage(string message, ConsoleColor messageColor)    //Datentyp, Variablenbezeichnung
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = messageColor;

            Console.Write(message);

            Console.ForegroundColor = oldColor;
            //Jetzt hat die Methode den Vorteil das sie den Orginalzustand wiederherstellt und somit etwas einmalig ohne spuren zu hinterlassen ausführt.
        }

        static void PrintMessage(string message)
        {
            message += "Damian"; //Das nennt man Hack, jetzt hat message immer den Wert Damian hinten dran (durch das + wird es hinten angehängt)
            Console.WriteLine(message);
        }

        //Signatur
        //RückgabeTyp MethodenBezeichnung(Parameter ParameterBezeichnung)
        static void PrinterHelloWorld()
        {
            Console.WriteLine("Hello World");
        }

    }
}
