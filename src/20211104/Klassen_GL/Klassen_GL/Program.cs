using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.ConsoleTools.Misc;

namespace Klassen_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanziierung
            Mitarbeiter ma = new Mitarbeiter();

            //Klasse / Object = Instanz
            ma.Name = "Gandalf";
            ma.Geschlecht = Gender.Male;
            ma.ChangeName("Gandalf der Graue");

            ma.DisplayInfos();

            //Klasse ist ein Datentyp, im oberen Beispiel die Klasse Mitarbeiter
            // ma ist ein Object/Instanz
            
        }
    }
}
