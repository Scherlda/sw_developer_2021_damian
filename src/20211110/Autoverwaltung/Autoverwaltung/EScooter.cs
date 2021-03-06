using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoverwaltung
{
    public  class EScooter : Fahrzeug
    {
        private double _batKapacity;

        public EScooter(VehicleType marke, string bezeichnung, int maxSpeed, double batteryCap)
            : base(marke, bezeichnung, maxSpeed) //Muss mit dem Init in Fahrzeug() übereinstimmen, befüllt den Fahrzeug Konstruktor welcher die drei Werte fasst.
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
