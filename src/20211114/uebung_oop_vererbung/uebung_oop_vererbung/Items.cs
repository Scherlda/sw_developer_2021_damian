using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uebung_oop_vererbung
{
    internal class Items
    {
        private ProductManufacturer _manufacturer;
        private string _productname;

        public Items(ProductManufacturer manufacturer, string productname)
        {
            _manufacturer = manufacturer;
            _productname = productname;
        }

        public ProductManufacturer Manufacturer
        {
            get { return _manufacturer; }
        }

        public string Produktname
        {
            get { return _productname; }
        }
    }
}
