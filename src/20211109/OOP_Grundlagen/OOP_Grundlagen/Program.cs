using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.ConsoleTools.Misc;

namespace OOP_Grundlagen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mitarbeiter ma = new Mitarbeiter("Gandalf", Gender.Male, new DateTime(1890, 5, 20));
            Mitarbeiter ma2 = new Mitarbeiter("Marta", Gender.Male, new DateTime(2000, 4, 10));
            DisplayEmployee(ma);

            ma.DisplayInfos();
            
            Console.WriteLine(ma.Name);
        }


        private static void DisplayEmployee(Mitarbeiter ma)
        {
            Console.WriteLine($"ID: {ma.Id}");
        }
    }
}
