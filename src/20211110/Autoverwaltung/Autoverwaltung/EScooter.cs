using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoverwaltung
{
    internal class EScooter : Auto
    {
        private double _batKapacity;

        public EScooter(VehicleType marke, string bezeichnung, int maxSpeed, double batteryCap)
            : base(marke, bezeichnung, maxSpeed) //Muss mit dem Init in Auto() übereinstimmen
        {
            _batKapacity = batteryCap;
        }

        public double BatKapacity
        {
            get { return _batKapacity; }
            set { _batKapacity = value; }
        }

    }
}
