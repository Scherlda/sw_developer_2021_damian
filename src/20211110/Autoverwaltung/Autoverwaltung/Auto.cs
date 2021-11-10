using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autoverwaltung;

namespace Autoverwaltung
{
    class Auto
    {
        private int _currentSpeed;
        private string _bezeichnung;
        private int _maxSpeed;
        private VehicleType _marke;
        
        public Auto()
        {
            Init(VehicleType.Tesla, "Default Auto", 160);
        }

        private void Init(VehicleType marke, string bezeichnung, int maxSpeed)
        {
            _currentSpeed = 0;
            _bezeichnung = bezeichnung;
            _maxSpeed = maxSpeed;
            _marke = marke;
        }

        public Auto(string bezeichnung)
        {

            _currentSpeed = 0;
            _maxSpeed = 160;
            _bezeichnung = bezeichnung;
            _marke = VehicleType.Tesla;
        }

        public Auto(VehicleType marke, string bezeichnung,int maxSpeed, int currentSpeed)
        {
            _currentSpeed = currentSpeed;
            _bezeichnung = bezeichnung;
            _maxSpeed = maxSpeed;
            _marke = marke;
        }

        public Auto(VehicleType marke, string bezeichnung, int maxSpeed)
        {            
            _bezeichnung = bezeichnung;
            _maxSpeed = maxSpeed;
            _marke = marke;
        }

        public int CurrentSpeed
        {
            get { return _currentSpeed; }
        }
        
        public string Bezeichnung
        {
            get { return _bezeichnung;}
            set 
            {
                if(!string.IsNullOrEmpty(value))
                _bezeichnung = value;
            }
        }

        public int MaxSpeed
        {
            get { return _maxSpeed;}
        }

        public VehicleType Marke
        {
            get { return _marke;}
        }

        public void SpeedUp(int delta)
        {
            if ((_currentSpeed + delta) <= MaxSpeed)
            _currentSpeed += delta;
        }
        public string GetInfoString()
        {
            string output = $"{_marke} {_bezeichnung}\n";
            output += $" {_currentSpeed}  / {_maxSpeed} hm/h";

            return output;
        }
    }
}
