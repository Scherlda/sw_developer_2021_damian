using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto[] myCars = new Auto[]
            {
                new Auto(VehicleType.Audi, "A1", 200),
                new Auto(VehicleType.BMW, "3er", 220),
                new Auto(VehicleType.Tesla, "Model S", 250),
                new Auto(VehicleType.Volkswagen, "Polo", 180)
            };

            DisplayCars(myCars);

            //EScooter erbt von Auto, in dem Beispiel wie es hier verwendet wird, spricht man von einer IST - EIN beziehung
            EScooter scooter = new EScooter(VehicleType.Xiaomi, "Speedy", 25, 360.0);

            Console.WriteLine(scooter.GetInfoString());

        }

        private static void DisplayCars(Auto[] carsToDisplay)
        {
            foreach (Auto car in carsToDisplay)
            {
                Console.WriteLine(car.GetInfoString());
                Console.WriteLine();
            }
        }
    }
}
