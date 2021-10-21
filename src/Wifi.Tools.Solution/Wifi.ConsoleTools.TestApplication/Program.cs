using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.ConsoleTools.TestApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Durch den Dateiname mit . wird eine Art Ordner erstellt. deshalb kann zuerst Wifi angegeben werden.
            Wifi.ConsoleTools.UIHelper.PrintColorMessage("Hallo liebe Leute!", ConsoleColor.Green);
            ConsoleTools.UIHelper.PrintColorMessage("Hallo liebe Leute!", ConsoleColor.Green);
            //Durch die Implementierung in dern References kann mit dem Direkten Dateinamen (Dll file) auf deren Klassen zugreifen
            UIHelper.PrintColorMessage("Hallo liebe Leute!", ConsoleColor.Green);
           
        }
    }
}
