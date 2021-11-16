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
            CreateTheBill(myVehicles, TimeSpan.FromHours(12.0));
        }

        private static void CreateTheBill(Fahrzeug[] vehicleList, TimeSpan rentDuration)
        {
            foreach (var vehicle in vehicleList)
            {
                Console.WriteLine($"{vehicle.Bezeichnung} - {vehicle.PricePerHour}EUR/h");
                Console.WriteLine($"Preis 1/2 Tag: {vehicle.CalculateRentCosts(rentDuration)} EUR");

            }
        }

        private static void DisplayInfos(Fahrzeug[] vehicleList)
        {
            foreach (var vehicle in vehicleList)
            {
                Console.WriteLine(vehicle.GetInfoString());
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
