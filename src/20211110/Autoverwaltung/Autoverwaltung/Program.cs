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
            Fahrzeug[] myCars = new Fahrzeug[]
            {
                new Auto(VehicleType.Audi, "A1", 200, FuelType.Benzin),
                new Sportwagen(VehicleType.BMW, "3er", 220, FuelType.Diesel, 350),
                new Fahrzeug(VehicleType.Tesla, "Model S", 250),
                new EScooter(VehicleType.Xiaomi, "Speedy", 180, 150.0),
                
            };

            //DisplayCars(myCars);

            //Fahrzeug aCar = myCars[0];

            //aCar.SoundMachine.ChangePowerState(PowerState.On);
            //aCar.SoundMachine.MakeSound();

            //Variable Datentypen
            var eineGanzeZahl = 0;
            var meinFahrzeug = new EScooter(VehicleType.Xiaomi, "blabla", 25, 120.5);

            
        }

        private static void DisplayCars(Fahrzeug[] carsToDisplay)
        {
            foreach (Fahrzeug car in carsToDisplay)
            {
                Console.WriteLine(car.DisplayInfos());
                Console.WriteLine();
            }
        }
    }
}
