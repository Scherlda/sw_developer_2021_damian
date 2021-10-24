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
        /// <summary>
        /// Reads the Users input at a specified position and check if the input is in the correct format.
        /// If there is an Format Error, the User have to reinput his data.
        /// </summary>
        /// <param name="positionLeft">Set the Postion of the courser from the left Panel.</param>
        /// <param name="positionTop">Set the Postion of the courser from the top Panel.</param>
        /// <param name="timeForSleep">Sets the time in milliseconds for the display of the error text.</param>
        /// <returns>Returns a int</returns>
        public static int Int_CheckInputAndRepositionMouse(int positionLeft, int positionTop, int timeForSleep)
        {
            int number = 0;
            int waitTimeNewInput = timeForSleep;
            Console.SetCursorPosition(positionLeft, positionTop);

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                do
                {
                    Console.SetCursorPosition(positionLeft, positionTop);
                    Console.Write($"Es sind nur Zahlen erlaubt! Versuche es erneut in {waitTimeNewInput.ToString().Trim('0')} Sekunden");
                    Thread.Sleep(1000);
                    waitTimeNewInput -= 1000;
                } while (waitTimeNewInput > 0);

                waitTimeNewInput = 3000;
                Console.SetCursorPosition(positionLeft, positionTop);
                Console.Write(new string(' ', Console.WindowWidth - (positionLeft-1)));
                Console.SetCursorPosition(positionLeft, positionTop);
            }
            return number;
        }
        /// <summary>
        /// Reads the Users input at a specified position and check if the input is in the correct format.
        /// If there is an Format Error, the User have to reinput his data.
        /// </summary>
        /// <param name="positionLeft">Set the Postion of the courser from the left Panel.</param>
        /// <param name="positionTop">Set the Postion of the courser from the top Panel.</param>
        /// <returns>Returns a int</returns>
        public static int Int_CheckInputAndRepositionMouse(int positionLeft, int positionTop)
        {
            int number = 0;
            Console.SetCursorPosition(positionLeft, positionTop);

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.SetCursorPosition(positionLeft, positionTop);
                Console.Write(new string(' ', Console.WindowWidth - (positionLeft-1)));
                Console.SetCursorPosition(positionLeft, positionTop);
            }
            return number;
        }

        /// <summary>
        /// Reads the Users input at a specified position and check if the input is in the correct format.
        /// If there is an Format Error, the User have to reinput his data.
        /// </summary>
        /// <param name="positionLeft">Set the Postion of the courser from the left Panel.</param>
        /// <param name="positionTop">Set the Postion of the courser from the top Panel.</param>
        /// <param name="timeForSleep">Sets the time in milliseconds for the display of the error text.</param>
        /// <returns>Returns a double</returns>
        public static double Double_CheckInputAndRepositionMouse(int positionLeft, int positionTop, int timeForSleep)
        {
            double number = 0;
            int waitTimeNewInput = timeForSleep;
            Console.SetCursorPosition(positionLeft, positionTop);

            while (!double.TryParse(Console.ReadLine(), out number))
            {
                do
                {
                    Console.SetCursorPosition(positionLeft, positionTop);
                    Console.Write($"Es sind nur Zahlen erlaubt! Versuche es erneut in {waitTimeNewInput.ToString().Trim('0')} Sekunden");
                    Thread.Sleep(1000);
                    waitTimeNewInput -= 1000;
                } while (waitTimeNewInput > 0);

                waitTimeNewInput = 3000;
                Console.SetCursorPosition(positionLeft, positionTop);
                Console.Write(new string(' ', Console.WindowWidth - (positionLeft-1)));
                Console.SetCursorPosition(positionLeft, positionTop);
            }
            return number;
        }

        /// <summary>
        /// Reads the Users input at a specified position and check if the input is in the correct format.
        /// If there is an Format Error, the User have to reinput his data.
        /// </summary>
        /// <param name="positionLeft">Set the Postion of the courser from the left Panel.</param>
        /// <param name="positionTop">Set the Postion of the courser from the top Panel.</param>
        /// <returns>Returns a double</returns>
        public static double Double_CheckInputAndRepositionMouse(int positionLeft, int positionTop)
        {
            double number = 0;
            Console.SetCursorPosition(positionLeft, positionTop);

            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.SetCursorPosition(positionLeft, positionTop);
                Console.Write(new string(' ', Console.WindowWidth - (positionLeft - 1)));
                Console.SetCursorPosition(positionLeft, positionTop);
            }
            return number;
        }
    }
}
