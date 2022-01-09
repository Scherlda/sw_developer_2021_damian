using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lebewesen_Item;

namespace lebewesen_main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ILebewesen> lebewesenList = new List<ILebewesen>();

            lebewesenList.Add(new Hund());
            lebewesenList.Add(new Katze());
            lebewesenList.Add(new Mensch());

            foreach (var item in lebewesenList)
            {
                Console.WriteLine(item.GibLaut());
            }

        }
    }
}
