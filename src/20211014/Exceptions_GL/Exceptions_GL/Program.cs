using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int geburtsJahr = 0;
            int alter = 0;
            bool isInputValid = false;

            Console.Write("Bitte Geburtsjahr eingeben: ");

            try //Code in diesem Block ist nicht perfomant
            {
                geburtsJahr = int.Parse(Console.ReadLine()); //Passiert hier ein Fehler dann wird das Programm auch hier beendet und der bool wird nie auf true gesetzt
                isInputValid = true;
            }
            catch
            {
                Console.WriteLine("Ups!, leider ist etwas schief gegangen!");
                isInputValid = false;
            }

            if (isInputValid == true)
            {
                alter = DateTime.Now.Year - geburtsJahr;

                Console.WriteLine("Du bist {0} Jahre alt", alter);
            }


        }
    }
}
