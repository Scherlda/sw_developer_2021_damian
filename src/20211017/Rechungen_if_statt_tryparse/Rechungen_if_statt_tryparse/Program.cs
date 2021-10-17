using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechungen_if_statt_tryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Werte des Trapez
            double sideA = 0;
            double sideB = 0;
            double sideC = 0;
            double sideD = 0;
            double sideH = 0;
            double areaOfTrapez = 0;
            double scopeOfTrapez = 0;

            Console.Title = "Trapez Calculator";

            //Fehlerfreies befüllen der Trapez-Seiten
            Console.Write("\t\t\tGuten Tag!\nDieses Programm berechnet den Flächeninhalt und den Umfang eines Trapez\n");
            sideA = IsUserInputValid("a");
            sideB = IsUserInputValid("b");
            sideC = IsUserInputValid("c");
            sideD = IsUserInputValid("d");
            sideH = IsUserInputValid("h");

            //Berechnen des Trapez
            areaOfTrapez = (sideA + sideB) * sideH / 2;
            scopeOfTrapez = sideA + sideB + sideC + sideD;
            
            //Ausgabe
            Console.Clear();
            Console.WriteLine("Der Flächeninhalt beträgt:\t{0}", areaOfTrapez);
            Console.WriteLine("Der Umfang beträgt:\t\t{0}", scopeOfTrapez);
            Console.ReadKey();

        }

        public static double IsUserInputValid ( string actualSide)
        {
            //Diese Methode überprüft die Usereingabe auf die richtigkeit und gibt dann die Seitenlänge zurück
            double sideofthetrapez = 0;
            string userInput = string.Empty;
            bool userInputIsOK = false;

            do
            {
                Console.Write("\nBitte geben Sie die Seite {0} ein: ", actualSide);
                userInput = Console.ReadLine();

                //Wenn die User eingabe korrekt ist => true
                if (double.TryParse(userInput, out sideofthetrapez))
                {
                    sideofthetrapez = double.Parse(userInput);
                    userInputIsOK = true;
                }
                else
                {
                    Console.WriteLine("Der eingegebe Wert war nicht OK!");
                    userInputIsOK = false;
                }

            } while (userInputIsOK == false);

            return sideofthetrapez;
        }
    }
}
