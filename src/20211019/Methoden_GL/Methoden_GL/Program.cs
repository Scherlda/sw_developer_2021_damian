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

            double gesamtGewicht = CalculateWeight(5, 1.3145);
            Console.WriteLine(gesamtGewicht);

            PrintColorMessage("Error: Hier ist was passiert.\n");
            PrintColorMessage("Error: Hier ist was passiert.\n", ConsoleColor.Blue);

            
        }

        //Methoden sollen kurz bleiben.
        //Methoden sollten Maximal eine bildschirmseite lang sein.

        static double CalculateWeight(int count, double weightPerPice)
        {
            double result = 0.0;

            result = weightPerPice * count;

            return result;

        }

        // ÜberladungsMethode, diese und die folgende Methode sind ident (Alles muss ident sein auch die Varialben Namen)
        // nur haben sie unterschiedlich viele Varialben, somit bekommt die Varialbe PrintColorMessage überladungen
        /// <summary>
        /// Print a colored message to default Output-Stream on the console.
        /// </summary>
        /// <param name="message">The message which should displayed</param>
        static void PrintColorMessage(string message) //Diese Methode gibt immer roten Text aus. Überladungen sollten immer möglichst den selben Code haben, dehasalb wird hier einfach die andere Methode aufgerufen und die Farbe mitgegeben
        {
            PrintColorMessage(message, ConsoleColor.Red);
        }

        // mit drei mal / kann die Doku für den Aufruf der Methode erstellt werden. (wird angezeigt wenn im Vorschlag die Methode angewählt wird.)

        /// <summary>
        /// Print a colored message to default Output-Stream on the console.
        /// </summary>
        /// <param name="message">The message which should displayed</param>
        /// <param name="messageColor">The color the provided message hould be displayed</param>
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
