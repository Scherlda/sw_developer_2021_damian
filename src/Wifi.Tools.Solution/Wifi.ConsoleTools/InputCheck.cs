using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.ConsoleTools
{
    public class InputCheck
    {
        public static int GetInt(string shownText)
        {
            int result = 0;
            Console.WriteLine($"{shownText}");
            try
            {
                result = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Die eingegeben Zahl passt nicht");
            }
            
            return result;
        }
    }
}
