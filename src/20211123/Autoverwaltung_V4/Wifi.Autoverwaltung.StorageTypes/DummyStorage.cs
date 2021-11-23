using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.Autoverwaltung.Core;
using Wifi.Autoverwaltung.VehicleTypes;

namespace Wifi.Autoverwaltung.StorageTypes
{
    public class DummyStorage : StorageBase
    {
        public override string Filename
        {
            get { return "dummy.car"; }
        }
        public override Fahrzeug[] Read()
        {
            var myVehiclelist = new Fahrzeug[]
            {
                new Auto(VehicleType.Audi,"superflizer 8",310, FuelType.Diesel),
                new EScooter(VehicleType.Xiaomi,"dontwalk 3", 35, 40.43),
                new Sportwagen(VehicleType.Volkswagen,"golf sport", 320, FuelType.Diesel, 350)
            };
            return myVehiclelist;
        }

        public override bool Write(Fahrzeug[] vehiclesToStore)
        {
            throw new NotImplementedException();
        }
    }
}

