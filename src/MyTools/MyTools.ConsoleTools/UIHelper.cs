using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools.ConsoleTools
{
    public class UIHelper
    {
        public static void PrintHeader(string headerText)
        {
            //Frames
            // ╔══╦══╗
            // ║  ║  ║ 
            // ╠══╬══╣
            // ║  ║  ║
            // ╚══╩══╝

            int xPosition = Console.WindowWidth / 2 - headerText.Length / 2;

            Console.Write("╔" + new string('═', Console.WindowWidth - 2) + "╗");
            Console.Write("║");
            Console.SetCursorPosition(xPosition, 1);
            Console.Write(headerText);
            Console.SetCursorPosition(Console.WindowWidth - 1, 1);
            Console.Write("║");
            Console.Write("╚" + new string('═', Console.WindowWidth - 2) + "╝");

        }
    }
}
