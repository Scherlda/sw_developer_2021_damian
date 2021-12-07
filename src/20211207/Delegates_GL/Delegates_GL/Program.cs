using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_GL
{
    public delegate void MeinSuperDelegate(); //Jetzt müssen die Methoden immer genau so aussehen (1)
    public delegate double OperationDelegate(double z1, double z2);
    public delegate void myFunktion(string data);


    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl = 5;
            MeinSuperDelegate eineMethode = HelloWord;

            eineMethode();

            OperationDelegate op = Multiplikaion;
            Console.WriteLine(op(15.2, 8.2));

            //In diesem Stil sollte man es in der Praxis nicht machen
            //Das ist eine Anonyme Methode
            //myFunktion eineFunktion = delegate (string data)
            //{
            //    var tmpData = data.ToLower();
            //    Console.WriteLine(tmpData);
            //};

            //eineFunktion("Hallo liebe Leute...");

            ////Lambda Expression
            //eineFunktion = (string data) =>
            //{
            //    var tmpData = data.ToUpper();
            //    Console.WriteLine(tmpData);
            //};

            //eineFunktion("Hallo liebe Leute...");

            ////Lambda Expression in kurz
            //eineFunktion = (data) => Console.WriteLine(data);

            //eineFunktion("Hallo liebe Leute...");

            //Guter Stil - Spart extrem viel Code, so muss nicht extra eine Methode geschrieben werden.
            int[] zahlenList = new[] { 1, 5, 6, 7, 8, 9, 15, 22, 35, 42 };

            DisplaySpecificNumbersOnly(zahlenList, (x) => x % 2 == 0);
            //auch ohne Klammern möglich
            DisplaySpecificNumbersOnly(zahlenList, x => x > 10);

        }
        public delegate bool FilterDelegate(int number);

        static void DisplaySpecificNumbersOnly(IEnumerable<int> numberList, FilterDelegate filter)
        {
            foreach (var number in numberList)
            {
                if (filter(number))
                {
                    Console.WriteLine(number);
                }
            }
        }

        private static double Addition(double z1, double z2)
        {
            return z1 + z2;
        }

        private static double Multiplikaion(double z1, double z2)
        {
            return z1 * z2;
        }

        

        //(1)
        static void HelloWord()
        {
            Console.WriteLine("Hello World");
        }
    }
}
