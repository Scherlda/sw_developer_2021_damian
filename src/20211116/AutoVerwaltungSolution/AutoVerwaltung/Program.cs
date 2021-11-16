using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoVerwaltung.Core;
using AutoVerwaltung.Core.Base;

namespace AutoVerwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myVehicles = new Fahrzeug[]
            {
                new Auto(VehicleType.Tesla, "Tesla Model F",230, FuelType.Strom),
                new EScooter(VehicleType.Xiaomi, "Happy Roller",35, 15.645),
                new Sportwagen(VehicleType.Audi, "Super Speedy",350, FuelType.Diesel, 450)
            };

            //process them
            PowerMusicProvider(myVehicles);

            DisplayInfos(myVehicles);
        }

        private static void DisplayInfos(Fahrzeug[] vehicleList)
        {
            foreach (var vehicle in vehicleList)
            {
                Console.WriteLine(vehicle.DisplayInfos());
                Console.WriteLine();
            }
        }

        private static void PowerMusicProvider(Fahrzeug[] vehicleList)
        {
            foreach (var vehicle in vehicleList)
            {
                vehicle.ChangeRadioState(PowerState.On);
            }
        }
    }
}
