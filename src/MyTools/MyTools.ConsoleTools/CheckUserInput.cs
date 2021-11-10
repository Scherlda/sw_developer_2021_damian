using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyTools.ConsoleTools
{
    public class CheckUserInput
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
            int inputNumber = 0;
            int waitTimeNewInput = timeForSleep;
            Console.SetCursorPosition(positionLeft, positionTop);

            //Liest den in der Console Eingegebe Wert und versucht diesen in einen Int umzuwanlden
            while (!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                //Gibt eine Fehlermeldung mit einem Timer aus welche siche jede Sekunde aktualisiert
                do
                {
                    Console.SetCursorPosition(positionLeft, positionTop);
                    Console.Write($"Es sind nur Zahlen erlaubt! Versuche es erneut in {waitTimeNewInput.ToString().Trim('0')} Sekunden");
                    Thread.Sleep(1000);
                    waitTimeNewInput -= 1000;
                } while (waitTimeNewInput > 0);
                
                //Leert die Zeile in welcher die Fehlermeldung steht. + Setzt timer wieder zurück
                waitTimeNewInput = timeForSleep;
                Console.SetCursorPosition(positionLeft, positionTop);
                Console.Write(new string(' ', Console.WindowWidth - (positionLeft-1)));
                Console.SetCursorPosition(positionLeft, positionTop);
            }
            return inputNumber;
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
            int inputNumber = 0;
            Console.SetCursorPosition(positionLeft, positionTop);

            while (!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.SetCursorPosition(positionLeft, positionTop);
                Console.Write(new string(' ', Console.WindowWidth - (positionLeft-1)));
                Console.SetCursorPosition(positionLeft, positionTop);
            }
            return inputNumber;
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
            double inputNumber = 0;
            int waitTimeNewInput = timeForSleep;
            Console.SetCursorPosition(positionLeft, positionTop);

            while (!double.TryParse(Console.ReadLine(), out inputNumber))
            {
                do
                {
                    Console.SetCursorPosition(positionLeft, positionTop);
                    Console.Write($"Es sind nur Zahlen erlaubt! Versuche es erneut in {waitTimeNewInput.ToString().Trim('0')} Sekunden");
                    Thread.Sleep(1000);
                    waitTimeNewInput -= 1000;
                } while (waitTimeNewInput > 0);

                waitTimeNewInput = timeForSleep;
                Console.SetCursorPosition(positionLeft, positionTop);
                Console.Write(new string(' ', Console.WindowWidth - (positionLeft-1)));
                Console.SetCursorPosition(positionLeft, positionTop);
            }
            return inputNumber;
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
            double inputNumber = 0;
            Console.SetCursorPosition(positionLeft, positionTop);

            while (!double.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.SetCursorPosition(positionLeft, positionTop);
                Console.Write(new string(' ', Console.WindowWidth - (positionLeft - 1)));
                Console.SetCursorPosition(positionLeft, positionTop);
            }
            return inputNumber;
        }

        /// <summary>
        /// Reads the Users input at a specified position and check if the input is not empty.
        /// If there is an Format Error, the User have to reinput his data.
        /// </summary>
        /// <param name="positionLeft">Set the Postion of the courser from the left Panel.</param>
        /// <param name="positionTop">Set the Postion of the courser from the top Panel.</param>
        /// <param name="timeForSleep">Sets the time in milliseconds for the display of the error text.</param>
        /// <returns>Returns an string</returns>
        public static string String_CheckInputEmptyAndRepositionMouse(int positionLeft, int positionTop, int timeForSleep)
        {
            string inputSpring = String.Empty;
            int waitTimeNewInput = timeForSleep;
            Console.SetCursorPosition(positionLeft, positionTop);

            do
            {
                inputSpring = Console.ReadLine();
                if (inputSpring == String.Empty)
                {
                    do
                    {
                        Console.SetCursorPosition(positionLeft, positionTop);
                        Console.Write($"Es wurde nichts eingegeben Versuche es erneut in {waitTimeNewInput.ToString().Trim('0')} Sekunden");
                        Thread.Sleep(1000);
                        waitTimeNewInput -= 1000;
                    } while (waitTimeNewInput > 0);

                    waitTimeNewInput = timeForSleep;
                    Console.SetCursorPosition(positionLeft, positionTop);
                    Console.Write(new string(' ', Console.WindowWidth - (positionLeft - 1)));
                    Console.SetCursorPosition(positionLeft, positionTop);
                }

            } while (inputSpring == string.Empty);
            return inputSpring;
        }

        /// <summary>
        /// Reads the Users input at a specified position and check if the input is an int with four letters.
        /// If there is an Format Error, the User have to reinput his data.
        /// </summary>
        /// <param name="positionLeft">Set the Postion of the courser from the left Panel.</param>
        /// <param name="positionTop">Set the Postion of the courser from the top Panel.</param>
        /// <param name="timeForSleep">Sets the time in milliseconds for the display of the error text.</param>
        /// <returns>Returns an DateTime with 01.01.%Year from user input%</returns>
        public static DateTime DateYear_CheckInputAndRepositionMouse( int positionLeft, int positionTop, int timeForSleep)
        {
            string dateCompletion = string.Empty;
            int waitTimeNewInput = timeForSleep;
            DateTime DateYear = DateTime.Now;
            bool isUserInputCorrect = false;

            Console.SetCursorPosition(positionLeft, positionTop);
            do
            {
                dateCompletion = $"01.01.{MyTools.ConsoleTools.CheckUserInput.Int_CheckInputAndRepositionMouse(positionLeft, positionTop, 2000)}";
                if (DateTime.TryParse(dateCompletion, out DateYear) == false)
                {
                    do
                    {
                        Console.SetCursorPosition(positionLeft, positionTop);
                        Console.Write($"Es sind nur die vier Jahres Zahlen erlaubt! Versuche es erneut in {waitTimeNewInput.ToString().Trim('0')} Sekunden");
                        Thread.Sleep(1000);
                        waitTimeNewInput -= 1000;
                    } while (waitTimeNewInput > 0);

                    waitTimeNewInput = timeForSleep;
                    Console.SetCursorPosition(positionLeft, positionTop);
                    Console.Write(new string(' ', Console.WindowWidth - (positionLeft - 1)));
                    Console.SetCursorPosition(positionLeft, positionTop);
                }
                else
                {
                    isUserInputCorrect = true;
                }

            } while (isUserInputCorrect == false);
            return DateYear;
        }

        public static void FalseInputTimerAndRepositionCourser(int positionLeft, int positionTop, int timeForSleep, string errorText)
        {
            int waitTimeNewInput = timeForSleep;
            do
            {
                Console.SetCursorPosition(positionLeft, positionTop);
                Console.Write($"{errorText} Versuche es erneut in {waitTimeNewInput.ToString().Trim('0')} Sekunden");
                Thread.Sleep(1000);
                waitTimeNewInput -= 1000;
            } while (waitTimeNewInput > 0);
            
            Console.SetCursorPosition(positionLeft, positionTop);
            Console.Write(new string(' ', Console.WindowWidth - (positionLeft - 1)));
            Console.SetCursorPosition(positionLeft, positionTop);
        }


       
       
    }
}
