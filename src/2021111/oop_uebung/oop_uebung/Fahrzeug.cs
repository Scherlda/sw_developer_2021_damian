using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_uebung
{
    class Fahrzeug
    {
        private int _currentSpeed;
        private int _maxSpeed;
        private string _manufacturer;
        private string _modelName;
               

        public int CurremtSpeed
        {
            get { return _currentSpeed; }
        }

        public int MaxSpeed
        {
            get { return _maxSpeed; }
        }

        public string Manufacturer
        {
            get { return _manufacturer; }
        }

        public string ModelName
        {
            get { return _modelName; }
        }

    }
}
