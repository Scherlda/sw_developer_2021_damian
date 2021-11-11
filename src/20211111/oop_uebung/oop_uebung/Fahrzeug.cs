using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_uebung
{
    class Fahrzeug
    {
        private string _manufacturer;
        private string _modelName;
        private int _currentSpeed;
        private int _maxSpeed;

        public void SpeedUp(int delta)
        {
            _currentSpeed += delta;    
        }

        public Fahrzeug()
        {
            Init();
        }

        public Fahrzeug(string manufacturer, string modelName, int currentSpeed, int maxSpeed)
        {
            _manufacturer = manufacturer;
            _modelName = modelName;
            _currentSpeed = currentSpeed;
            _maxSpeed = maxSpeed;
        }

        private void Init()
        {
            _manufacturer = "Beispiel-Hersteller";
            _modelName = "Pegasus";
            _currentSpeed = 0;
            _maxSpeed = 25;            
        }

        public string Manufacturer
        {
            get { return _manufacturer; }
        }

        public string ModelName
        {
            get { return _modelName; }
        }

        public int CurremtSpeed
        {
            get { return _currentSpeed; }
        }

        public int MaxSpeed
        {
            get { return _maxSpeed; }
        }

        
    }
}
