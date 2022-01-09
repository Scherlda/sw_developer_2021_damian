using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lebewesen_Item
{
    public class Hund : ILebewesen
    {
        private int _anzahlBeine;
        private int _koerperhoeheInCm;

        public string GibLaut()
        {
            return "Wau, Wuff";
        }

        public int AnzahlBeine
        {
           get { return _anzahlBeine;}
        }

        public int KoerperhoeheInCm
        {
            get { return _koerperhoeheInCm; }
        }
    }
}
