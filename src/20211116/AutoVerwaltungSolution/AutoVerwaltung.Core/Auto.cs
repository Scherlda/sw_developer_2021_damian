using AutoVerwaltung.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVerwaltung.Core
{
    public class Auto : Fahrzeug
    {
        private FuelType _fuel;

        public Auto(VehicleType marke, string bezeichnung, int maxSpeed, FuelType kraftstoff)
            : base(marke, bezeichnung, maxSpeed)
        {
            _fuel = kraftstoff;

        }

        public FuelType Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        //Basis Klasse implementieren und erweitern
        public override string DisplayInfos()
        {
            var infos = base.DisplayInfos();
            infos += $"\n Fuel Type: {_fuel}";

            return infos;
        }

    }
}
