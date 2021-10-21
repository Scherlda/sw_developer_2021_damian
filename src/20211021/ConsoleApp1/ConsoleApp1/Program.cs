using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string headerText = "Test Program";
            int xPos = Console.WindowWidth / 2 - headerText.Length / 2;

            Console.WriteLine(new string('#', Console.WindowWidth));
            Console.SetCursorPosition(2,xPos);
            Console.WriteLine(new String('#', Console.WindowWidth));



        }
    }
}
