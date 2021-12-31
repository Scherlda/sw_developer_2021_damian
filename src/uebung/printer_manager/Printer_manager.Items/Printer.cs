using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer_manager.Items
{
    public class Printer : INetworkHardware
    {
        private bool _isMultiFunctional;
        private bool _hasMultiColor;
        private int ageCapacity;

        public string MacAddress => throw new NotImplementedException();

        public bool HasStaticIPAddress => throw new NotImplementedException();

        public string IPAdress => throw new NotImplementedException();

        public string Modelname => throw new NotImplementedException();

        public string Serial => throw new NotImplementedException();

        public string Status => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public string UserDescription => throw new NotImplementedException();

        public string Manufacturer => throw new NotImplementedException();
    }
}
