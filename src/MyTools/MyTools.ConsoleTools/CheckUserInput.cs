using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyTools.ConsoleTools
{
    internal class CheckUserInput
    {
        public static int CheckInputRepositionMouse(int positionLeft, int positionRight)
        {
            int number = 0;
            int waitTimeNewInput = 3000;
            Console.SetCursorPosition(30, 9);

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                do
                {
                    Console.SetCursorPosition(30, 9);
                    Console.Write($"Es sind nur Zahlen erlaubt! Versuche es erneut in {waitTimeNewInput.ToString().Trim('0')} Sekunden");
                    Thread.Sleep(1000);
                    waitTimeNewInput -= 1000;
                } while (waitTimeNewInput > 0);

                waitTimeNewInput = 3000;
                Console.SetCursorPosition(30, 9);
                Console.Write(new string(' ', Console.WindowWidth - 31));
                Console.SetCursorPosition(30, 9);
            }
            return number;
        }
    }
}
