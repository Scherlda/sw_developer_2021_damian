using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreisberechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parameters of circle
            double radius = 0;
            double diameter = 0;
            double scope = 0;
            double area = 0;
            bool isInputCorrect = false;

            

            Console.WriteLine("\t\t\tGuten Tag");
            Console.WriteLine("Dieses Programm dient der Berechnung eines Kreises und dessen Werte\n\nBitte gib den Radius deines Kreises ein: ");

            //check if user Input for radius is OK
            while (isInputCorrect == false)
            {
                try
                {
                    radius = double.Parse(Console.ReadLine());
                    if (radius == 0)
                    {
                        Console.Write("0 ist kein gültiger Wert\nbitte gib eine andere Zahl ein: ");
                        isInputCorrect = false;
                    }
                    else if (radius < 0)
                    {
                        Console.Write("Negative Zahlen sind nicht erlaub\nBitte gib eine Positive Zahl ein: ");
                        isInputCorrect = false;
                    }
                    else
                    {
                        isInputCorrect = true;
                    }
                }
                catch (FormatException)
                {
                    Console.Write("Der Eingegebe Wert entpsricht nicht einer Zahl.\nEs sind nur Zahlen erlaubt!\nBitte gib einen neuen Wert ein: ");
                    isInputCorrect = false;
                }
                catch (Exception)
                {
                    Console.Write("Die Eingabe war nicht OK\nBitte gib einen neuen Wert ein: ");
                    isInputCorrect = false;
                } 
            }

            //Calculate the Circle
            diameter = 2 * radius;
            scope = 2 * Math.PI * radius;
            area = Math.PI * Math.Pow(radius, 2);

            //output
            Console.Clear();
            Console.WriteLine("Die Werte des Kreises sind wie folgt.");
            Console.Write("Der Radius beträgt:\t\t\t{0}\nDer Durchmesser beträgt:\t\t{1}\nDer Umfang beträgt:\t\t\t{2}\nDer Flächeninhalt beträgt:\t\t{3}", radius, diameter, scope, area);

            Console.ReadKey();
        }
    }
}
