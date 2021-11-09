using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.ConsoleTools.Misc;

namespace Klassen_GL
{
    class Mitarbeiter
    {
        public Guid ID; //
        public string Name;
        public Gender Geschlecht;

        public void ChangeName(string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                Name = newName;
            }
        }

        public void DisplayInfos()
        {
            Console.WriteLine($"ID:     [{ID}]");
            Console.WriteLine($"Name    {Name}");
            Console.WriteLine($"Gender: {Geschlecht}");
        }
    }
}
