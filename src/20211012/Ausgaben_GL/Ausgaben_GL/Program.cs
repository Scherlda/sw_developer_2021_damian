using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ausgaben_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hi, schön das du da bist");
            //Console.WriteLine("Mein Alter: " + 150);
            //Console.WriteLine("Ich bin {0} Jahre alt", 150);

            //Console.WriteLine("Hallo\nzusammen");
            //Console.WriteLine("\tHallo\nzusammen");
            //Console.WriteLine("Hallo\n\tzusammen");
            //Console.WriteLine("\t\tHallo\nzusammen\a");

            Console.SetCursorPosition(10, 1);   //Setzt die Courser Position an eine bestimmte Stelle in der Conosle.
            Console.WriteLine("Name: Damian");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("Geburts Jahr: 2000");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("Das halte ich von C#:");
            Console.SetCursorPosition(8, 5);
            Console.WriteLine("C# ist eine tolle Sache!");
            
            Console.ReadLine();

        }
    }
}
