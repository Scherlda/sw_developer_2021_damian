using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lebewesen_Item;
using lebewesen_Repository;

namespace lebewesen_main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Lebewesen> lebewesenList = new List<Lebewesen>();

            lebewesenList.Add(new Hund(4, 50));
            lebewesenList.Add(new Katze(4, 30));
            lebewesenList.Add(new Mensch(2, 170));
            lebewesenList.Add(new Hund(4, 40));

            foreach (var item in lebewesenList)
            {
                Console.WriteLine(item.GibLaut());
            }

            TxtFileSave save = new TxtFileSave();
            save.SaveToTxt(lebewesenList, @"C:\opt\test.txt");

        }
    }
}
