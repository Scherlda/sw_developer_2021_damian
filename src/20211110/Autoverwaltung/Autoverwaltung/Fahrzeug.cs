using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autoverwaltung;

namespace Autoverwaltung
{
    public class Fahrzeug
    {
        private int _currentSpeed;
        private int _maxSpeed;
        private VehicleType _marke;
        private string _bezeichnung;
              
        
        public Fahrzeug()
        {
            
        }
        public Fahrzeug(VehicleType marke, string bezeichnung, int maxSpeed)
        {
            Init(marke, bezeichnung, maxSpeed);
        }

        public Fahrzeug(VehicleType marke, string bezeichnung,int maxSpeed, int currentSpeed)
        {
            _currentSpeed = currentSpeed;
            _bezeichnung = bezeichnung;
            _maxSpeed = maxSpeed;
            _marke = marke;
        }        

        private void Init(VehicleType marke, string bezeichnung, int maxSpeed)
        {
            _currentSpeed = 0;
            _bezeichnung = bezeichnung;
            _maxSpeed = maxSpeed;
            _marke = marke;
        }


        //public Fahrzeug(string bezeichnung)
        //{

        //    _currentSpeed = 0;
        //    _maxSpeed = 160;
        //    _bezeichnung = bezeichnung;
        //    _marke = VehicleType.Tesla;
        //}

        public int CurrentSpeed
        {
            get { return _currentSpeed; }
        }
               

        public int MaxSpeed
        {
            get { return _maxSpeed;}
        }

        public VehicleType Marke
        {
            get { return _marke;}
        }
        public string Bezeichnung
        {
            get { return _bezeichnung; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _bezeichnung = value;
            }
        }

        public void SpeedUp(int delta)
        {
            if ((_currentSpeed + delta) <= MaxSpeed)
            _currentSpeed += delta;
        }
        public string DisplayInfos()
        {
            string output = $"{_marke} {_bezeichnung}\n";
            output += $" {_currentSpeed}  / {_maxSpeed} hm/h";

            return output;
        }
    }
}
