using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer_manager.Items
{
    public class PrinterItem : IPrinter
    {
        //Sortierung!!!!!!!!!!!!!!!!!!!!!!1
        private bool _hasMultiColor;
        private EPrinterType _selectKindOfPrinter;
        private string _modelName;
        private string _manuFacturer;
        private string _serial;
        private string _name;
        private ItemStatus _status;
        private string _macAddres;
        private bool _hasStaticAddress; //wenn ja:
        //Optionale Felder
        private string _ipAddress;
        private string _userDescription; 
        private string _price;

        public PrinterItem(bool hasMultiColor, EPrinterType selectKindOfPrinter, string modelName, string menuFacturer, string serial, string name, ItemStatus status, string macAddress, bool hasStaticAddress)
        {

        }

        public bool HasMulticolor => _hasMultiColor;

        public EPrinterType SelectKindOfPrinter => _selectKindOfPrinter;

        public string MacAddress => _macAddres;

        public bool HasStaticIPAddress => _hasStaticAddress;

        public string IPAdress => _ipAddress;

        public string Modelname => _modelName;

        public string Serial => _serial;

        public string Name => _name;

        public string UserDescription => _userDescription;

        public string Manufacturer => _manuFacturer;

        public ItemStatus Status => _status;

        public string Price => _price;
    }
}
