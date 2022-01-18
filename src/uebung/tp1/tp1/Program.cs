using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass(0,"Haus");
            TestClass test1 = new TestClass(12);

            Console.WriteLine("{0}, {1}", test.getWert1(), test.getWert2());
            Console.WriteLine("{0}, {1}", test1.getWert1(), test1.getWert2());



        }
    }
}
