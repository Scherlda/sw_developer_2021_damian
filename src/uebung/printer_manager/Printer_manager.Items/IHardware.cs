using Printer_manager.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_manager.Items
{
    public interface IHardware : IItem
    {

        string Modelname { get; } 
        string Serial { get; }  //Seriennummer
        string Status { get; }  //In Betrieb, Auf Lager, Beim Kunde, ...

    }
}
