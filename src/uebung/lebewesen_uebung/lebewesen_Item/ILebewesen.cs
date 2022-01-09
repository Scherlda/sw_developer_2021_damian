using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lebewesen_Item
{
    public interface ILebewesen
    {
        int AnzahlBeine { get; }
        int KoerperhoeheInCm { get; }

        string GibLaut();
    }
}
