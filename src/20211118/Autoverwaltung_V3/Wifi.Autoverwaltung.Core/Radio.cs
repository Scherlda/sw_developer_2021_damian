using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.Autoverwaltung.Core
{
    public class Radio
    {
        private string _bezeichnung;
        private PowerState _power;

        public Radio(string bezeichnung)
        {
            _bezeichnung = bezeichnung;
            _power = PowerState.Off;
        }

        public string Bezeichnung
        {
            get { return _bezeichnung; }
        }

        public PowerState Power
        {
            get { return _power; }
        }

        public void MakeSound()
        {
            if (_power.Equals(PowerState.On))
            {
                Console.WriteLine($"Radio {_bezeichnung} spielt Musik");
            }
        }

        public void ChangePowerState(PowerState newPowerState)
        {
            _power = newPowerState;
        }



    }
}
