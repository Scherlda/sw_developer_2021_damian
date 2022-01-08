using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer_manager.Items
{
    public interface IItem
    {
        string Name { get; }
        string UserDescription { get; }
        string Manufacturer { get; }

        EItemStatus Status { get; }  //In Betrieb, Auf Lager, Beim Kunde, ...
        double Price { get; } //Soll Optional sein
    }
}
