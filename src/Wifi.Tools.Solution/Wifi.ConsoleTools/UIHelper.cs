using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.ConsoleTools
{
    public class UIHelper
    {
        /// <summary>
        /// Print a colored message to default Output-Stream on the console.
        /// </summary>
        /// <param name="message">The message which should displayed</param>
        public static void PrintColorMessage(string message) //Diese Methode gibt immer roten Text aus. Überladungen sollten immer möglichst den selben Code haben, dehasalb wird hier einfach die andere Methode aufgerufen und die Farbe mitgegeben
        {
            PrintColorMessage(message, ConsoleColor.Red);
        }

        /// <summary>
        /// Print a colored message to default Output-Stream on the console.
        /// </summary>
        /// <param name="message">The message which should displayed</param>
        /// <param name="messageColor">The color the provided message hould be displayed</param>
        public static void PrintColorMessage(string message, ConsoleColor messageColor)    //Datentyp, Variablenbezeichnung
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = messageColor;

            Console.Write(message);

            Console.ForegroundColor = oldColor;
            //Jetzt hat die Methode den Vorteil das sie den Orginalzustand wiederherstellt und somit etwas einmalig ohne spuren zu hinterlassen ausführt.
        }
    }
}
