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
        private decimal _pricePerHour;

        public Auto(VehicleType marke, string bezeichnung, int maxSpeed, FuelType kraftstoff)
            : base(marke, bezeichnung, maxSpeed)
        {
            _fuel = kraftstoff;
            _pricePerHour = 35.5m;

        }

        public FuelType Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        public override decimal PricePerHour
        {
            get
            {
                return _pricePerHour;
            }
        }
        public override decimal CalculateRentCosts(TimeSpan rentDuration)
        {
            if (rentDuration.TotalDays < 1.0)
            {
                return PricePerHour * 24;
            }

            var dayToPay = rentDuration.Days;
            if (rentDuration.Hours > 0.0)
            {
                dayToPay++;
            }

            return dayToPay * 24 * PricePerHour;
        }



        //Basis Klasse implementieren und erweitern
        public override string GetInfoString()
        {
            var infos = base.GetInfoString();
            infos += $"\n Fuel Type: {_fuel}";

            return infos;
        }

    }
}
