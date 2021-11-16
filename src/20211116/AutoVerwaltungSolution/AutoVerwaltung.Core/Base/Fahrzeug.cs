using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVerwaltung.Core.Base
{
    public class Fahrzeug
    {
        private int _currentSpeed;
        private int _maxSpeed;
        private VehicleType _marke;
        private string _bezeichnung;
        private Radio _soundMachine;      //Durch das Eingfügen von Radio kann in dieser Klasse, methoden erzeugt werden welche einfluss auf Radio nehmen jedoch kann von außen niemand etwas an radio ändern.
                                          //Selbst wenn ich die Klasse Radio Komplet umbaua bleiben die Methoden über welche ein Kunde mittels Fahrzeug zugreift gleich. Dieses Prinzip nennt man Kapselung.


        public Fahrzeug(VehicleType marke, string bezeichnung, int maxSpeed)
        {
            Init(marke, bezeichnung, maxSpeed);
        }

        public Fahrzeug(VehicleType marke, string bezeichnung, int maxSpeed, int currentSpeed)
        {
            _currentSpeed = currentSpeed;
            _bezeichnung = bezeichnung;
            _maxSpeed = maxSpeed;
            _marke = marke;
        }

        private void Init(VehicleType marke, string bezeichnung, int maxSpeed)
        {
            _soundMachine = new Radio(bezeichnung + "-Radio");
            _currentSpeed = 0;
            _bezeichnung = bezeichnung;
            _maxSpeed = maxSpeed;
            _marke = marke;
        }


        public int CurrentSpeed
        {
            get { return _currentSpeed; }
        }


        public int MaxSpeed
        {
            get { return _maxSpeed; }
        }

        public VehicleType Marke
        {
            get { return _marke; }
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
            if (_currentSpeed + delta <= MaxSpeed)
                _currentSpeed += delta;
        }
        public virtual string DisplayInfos()
        {
            string output = $"{_marke} {_bezeichnung}\n";
            output += $" {_currentSpeed}  / {_maxSpeed} hm/h";

            return output;
        }

        public void ChangeRadioState(PowerState newPowerState)
        {
            _soundMachine.ChangePowerState(newPowerState);
        }

        public void PlayMusik()
        {
            _soundMachine.MakeSound();
        }

    }
}
