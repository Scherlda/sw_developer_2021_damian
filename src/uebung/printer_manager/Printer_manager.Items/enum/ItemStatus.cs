using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum ItemStatus
{
    [Description("In use")] Inuse = 1,
    [Description("Repair")] Repair = 2,
    [Description("Reserve")] Reserve = 3,
}