using lebewesen_Item;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lebewesen_Repository
{
    public class TxtFileSave
    {
        public bool SaveToTxt(List<Lebewesen> dataToExport, string filePath)
        {
            if (dataToExport == null || string.IsNullOrEmpty(filePath)) return false;
            

            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                foreach (Lebewesen lebewesen in dataToExport)
                {
                    sw.WriteLine(lebewesen);
                }
                
            }
            
            return true;

        }
    }
}
