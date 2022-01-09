using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_tests_uebung
{
    public class Calculating
    {
        private double _ergebniss;

        public double Addieren(double wert1, double wert2, double wert3 = 0)
        {
            return _ergebniss = wert1 + wert2 + wert3;
        }

        public double Ergebniss
        {
            get { return _ergebniss; }
        }
    }
}
