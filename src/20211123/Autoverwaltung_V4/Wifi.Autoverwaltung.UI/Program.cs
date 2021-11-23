using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.Autoverwaltung.Core;
using Wifi.Autoverwaltung.VehicleTypes;
using Wifi.Autoverwaltung.UI;
using Wifi.Autoverwaltung.StorageTypes;

namespace Wifi.Autoverwaltung.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string filename = string.Empty;
            Console.WriteLine("Bitte Datei mit Fahrzeugen eingaben: ");
            filename = Console.ReadLine();

            //storage objekt erzeugen
            //hier könnte genau so gut var storage = new DummyStorage() stehen, wichtig ist das hinten, diues drückt aus was initialisiert wird
            IStorageBase storage = new DummyStorage();

            var myVehicleList = storage.Read();
            if (myVehicleList.Length > 0)
            {
                CreatePriceList(myVehicleList, TimeSpan.FromHours(12));
            }

            var erg = storage.Write(myVehicleList);
            if (erg)
            {
                Console.WriteLine($"Daten wurde in Datei '{storage.Filename} gespeichert.");
            }
            

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
