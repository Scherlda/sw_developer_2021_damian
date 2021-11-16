﻿using AutoVerwaltung.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVerwaltung.Core
{
    public class Sportwagen : Auto
    {
        private int _ps;


        public Sportwagen(VehicleType marke, string bezeichnung, int maxSpeed, FuelType kraftStoff, int ps)
            : base(marke, bezeichnung, maxSpeed, kraftStoff)
        {
            _ps = ps;
        }

        public int PS
        {
            get { return _ps; }
            set { _ps = value; }
        }
        //
        public override string GetInfoString()
        {
            var infos = "(*)" + base.GetInfoString();
            infos += $"\nPS:{_ps}";

            return infos;
        }

        public override decimal PricePerHour
        {
            get
            {
                return 1.2m*base.PricePerHour;
            }
        }
    }
}
