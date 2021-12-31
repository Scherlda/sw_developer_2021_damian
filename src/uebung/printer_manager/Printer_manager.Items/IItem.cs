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
    }
}
