using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lebewesen_Item
{
    public class Katze : Lebewesen
    {
        public Katze(int anzahlBeine, int koerperhoeheInCm) : base(anzahlBeine, koerperhoeheInCm)
        {
        }

        override public string GibLaut()
        {
            return "Mew";
        }
    }
}
