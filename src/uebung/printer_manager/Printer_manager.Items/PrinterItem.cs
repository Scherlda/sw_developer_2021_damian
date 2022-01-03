using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer_manager.Items
{
    public class PrinterItem : IPrinter
    {
        //Item - Pflicht
        private string _name;        
        private string _manuFacturer;
        private ItemStatus _status;
        //Hardware - Pflicht
        private string _modelName;
        private string _serial;

        //Item-Optional
        private string _userDescription; 
        private double _price;        
        //NetworkCapatibleHardware - Optional
        private string _macAddres;
        private bool _hasStaticAddress; //wenn ja:
        private string _ipAddress;
        //Spezifisch - PrinterItem
        private bool _hasMultiColor;
        private EPrinterType _selectKindOfPrinter;

        public PrinterItem(string name, string manuFacturer, ItemStatus status, string modelName, string serial, 
            string macAddress, bool hasStaticAddress, bool hasMultiColor, EPrinterType selectKindOfPrinter,     //Optionale:
            string _userDescription = " ", double _price = 0.00, string _macAddress = " ", bool _hasStaticAddress = false, 
            string _ipAddress = " ", bool _hasMultiColor = false, EPrinterType _selectKindOfPrinter = EPrinterType.NormalPrinter)
        {
            _name = name;
            _manuFacturer = manuFacturer;
            _status = status;
            //_userDescription = String.Empty;
            //_price = 0.0;
            _modelName = modelName;
            _serial = serial;
            //_macAddres = macAddress;
            //_hasStaticAddress = hasStaticAddress;
            //_ipAddress = String.Empty;
            //_hasMultiColor = hasMultiColor;
            //_selectKindOfPrinter = selectKindOfPrinter;
        }

        //public PrinterItem(string name, string manuFacturer, ItemStatus status, string userDescription,
        //    string modelName, string serial,
        //    string macAddress, bool hasStaticAddress,
        //    bool hasMultiColor, EPrinterType selectKindOfPrinter)
        //    : this(name,  manuFacturer, status, modelName, serial, macAddress, hasStaticAddress, hasMultiColor, selectKindOfPrinter)
        //{
        //    _userDescription = userDescription;
        //}

        //public PrinterItem(string name, string manuFacturer, ItemStatus status, double price,
        //    string modelName, string serial,
        //    string macAddress, bool hasStaticAddress,
        //    bool hasMultiColor, EPrinterType selectKindOfPrinter)
        //    : this(name, manuFacturer, status, modelName, serial, macAddress, hasStaticAddress, hasMultiColor, selectKindOfPrinter)
        //{
        //    _price = price;
        //}

        //public PrinterItem(string name, string manuFacturer, ItemStatus status,
        //    string modelName, string serial,
        //    string macAddress, bool hasStaticAddress, string ipAddress,
        //    bool hasMultiColor, EPrinterType selectKindOfPrinter)
        //    : this(name, manuFacturer, status, modelName, serial, macAddress, hasStaticAddress, hasMultiColor, selectKindOfPrinter)
        //{
        //    _ipAddress = ipAddress;
        //}

        //public PrinterItem(string name, string manuFacturer, ItemStatus status, string userDescription, double price,
        //    string modelName, string serial,
        //    string macAddress, bool hasStaticAddress,
        //    bool hasMultiColor, EPrinterType selectKindOfPrinter)
        //    : this(name, manuFacturer, status, modelName, serial, macAddress, hasStaticAddress, hasMultiColor, selectKindOfPrinter)
        //{
        //    _userDescription = userDescription;
        //    _price = price;
        //}

        //public PrinterItem(string name, string manuFacturer, ItemStatus status, string userDescription,
        //    string modelName, string serial,
        //    string macAddress, bool hasStaticAddress, string ipAddress,
        //    bool hasMultiColor, EPrinterType selectKindOfPrinter)
        //    : this(name, manuFacturer, status, modelName, serial, macAddress, hasStaticAddress, hasMultiColor, selectKindOfPrinter)
        //{
        //    _userDescription = userDescription;
        //    _ipAddress = ipAddress;
        //}

        //public PrinterItem(string name, string manuFacturer, ItemStatus status, double price,
        //    string modelName, string serial,
        //    string macAddress, bool hasStaticAddress, string ipAddress,
        //    bool hasMultiColor, EPrinterType selectKindOfPrinter)
        //    : this(name, manuFacturer, status, modelName, serial, macAddress, hasStaticAddress, hasMultiColor, selectKindOfPrinter)
        //{
        //    _price = price;
        //    _ipAddress= ipAddress;
        //}

        //public PrinterItem(string name, string manuFacturer, ItemStatus status, string userDescription, double price,
        //    string modelName, string serial,
        //    string macAddress, bool hasStaticAddress, string ipAddress,
        //    bool hasMultiColor, EPrinterType selectKindOfPrinter)
        //    : this(name, manuFacturer, status, modelName, serial, macAddress, hasStaticAddress, hasMultiColor, selectKindOfPrinter)
        //{
        //    _userDescription= userDescription;
        //    _price = price;
        //    _ipAddress = ipAddress;
        //}

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

        public double Price => _price;
    }
}
