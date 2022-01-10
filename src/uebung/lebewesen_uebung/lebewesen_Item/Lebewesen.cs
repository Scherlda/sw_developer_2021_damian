using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lebewesen_Item
{
    public abstract class Lebewesen : ILebewesen
    {
        private int _anzahlBeine;
        private int _koerperHoeheInCm;

        public Lebewesen(int anzahlBeine, int koerperhoeheInCm)
        {
            _anzahlBeine = anzahlBeine;
            _koerperHoeheInCm = koerperhoeheInCm;
        }

        public int AnzahlBeine
        {
            get { return _anzahlBeine;}
        }

        public int KoerperhoeheInCm
        {
            get { return _koerperHoeheInCm; }
        }

        public abstract string GibLaut();
        
    }
}
