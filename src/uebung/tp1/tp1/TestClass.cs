using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class TestClass
    {
        int _wert1 = 0;
        string _wert2 = "";

        public TestClass(int wert1 = 1, string wert2 = "test")
        {
            _wert1 = wert1;
            _wert2 = wert2;
        }

        public int getWert1()
        {
            return _wert1;
        }

        public string getWert2()
        {
            return _wert2;
        }
    }
}
