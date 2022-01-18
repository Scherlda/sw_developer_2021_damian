using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Swd.BspArchitecture.Repository.XmlFile
{
    public class DataManager
    {
        public string ReadData()
        {
            string returnValue = string.Empty;
            string filePath = Properties.Settings.Default.PathToXMLFile;
            if (File.Exists(filePath))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);
                returnValue = xmlDoc.SelectSingleNode("Message/Text").InnerText;
            }

            return returnValue;
            //oder return "Hello world";
        }
    }
}
