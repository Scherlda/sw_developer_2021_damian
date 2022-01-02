using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum EPrinterType
{
    [Description("Normal Printer")] NormalPrinter = 1,
    [Description("Multifunctional Printer")] MultifunctionalPrinter = 2,
    [Description("Label Printer")] LabelPrinter = 3
}

