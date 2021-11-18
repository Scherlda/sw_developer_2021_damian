using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.Autoverwaltung.Core;
using Wifi.Autoverwaltung.VehicleTypes;

namespace Wifi.Autoverwaltung.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myVehicleList = new Fahrzeug[]
            {
                new Auto(VehicleType.Audi,"Superflizer 8",310, FuelType.Diesel),
                new EScooter(VehicleType.Xiaomi,"Dontwalk 3", 35, 40.43),
                new Sportwagen(VehicleType.Volkswagen,"Golf Sport", 320, FuelType.Diesel, 350)                
            };

            CreatePriceList(myVehicleList, TimeSpan.FromHours(12));

        }

        private static void CreatePriceList(Fahrzeug[] myVehicleList, TimeSpan duration)
        {
            Console.WriteLine("Preisliste:\n");
            foreach (var vehicle in myVehicleList)  
            {
                Console.WriteLine($"{vehicle.Bezeichnung}\t Pro Stunde: {vehicle.PricePerHour} EUR");
                Console.WriteLine($"Preis: {vehicle.CalculateRentCosts(duration)} EUR");
                Console.WriteLine(new String('-', Console.WindowWidth-1));
            }
        }
    }
}
