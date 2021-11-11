using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoverwaltung
{
    public class Sportwagen : Auto
    {
        private int _ps;        


        public Sportwagen(VehicleType marke, string bezeichnung, int maxSpeed,FuelType kraftStoff, int ps)
            :base(marke, bezeichnung, maxSpeed, kraftStoff)
        {
            _ps = ps;
        }

        public int PS
        {
            get { return _ps; }
            set { _ps = value; }
        }

    }
}
