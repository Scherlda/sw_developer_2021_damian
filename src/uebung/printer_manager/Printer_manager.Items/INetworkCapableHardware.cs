using Product_manager.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer_manager.Items
{
    public interface INetworkCapableHardware : IHardware
    {
        string MacAddress { get; }
        bool HasStaticIPAddress { get; }
        string IPAdress { get; }
    }
}
