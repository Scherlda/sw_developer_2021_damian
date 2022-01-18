using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lebewesen_Item
{
    public class Mensch : Lebewesen
    {
        public Mensch(int anzahlBeine, int koerperhoeheInCm) : base(anzahlBeine, koerperhoeheInCm)
        {
        }

        override public string GibLaut()
        {
            return "Blablabla";
        }
    }
}
