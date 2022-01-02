﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product_manager.Items;

namespace Printer_manager.Items
{
    public interface IPrinter : INetworkCapableHardware
    {
        bool HasMulticolor { get; }
        EPrinterType SelectKindOfPrinter { get; }
    }
}
