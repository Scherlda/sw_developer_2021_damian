using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.OleDb;
using Swd.BspArchitecture.Repository.Textfile;

namespace Swd.BspArchitecture.Repository
{
    public class DataFactory
    {        

        public string GetData()
        {
            //Greift jetzt auf die Eigenschaften welche in den (Rechtsklick auf das Projekt) Properties => Settings definiert wurde zu.
            Datasource datasource = (Datasource)Properties.Settings.Default.DataSource;
            string returnValue = string.Empty;


            switch (datasource)
            {
                case Datasource.Memory:
                    break;
                case Datasource.Textfile:
                    Textfile.DataManager dataManagerTextFile = new Textfile.DataManager();
                    returnValue = dataManagerTextFile.ReadData();//((Datasource)Properties.Settings.Default.DataPath);
                    break;
                case Datasource.XmlFile:
                    XmlFile.DataManager dataManagerXmlFile = new XmlFile.DataManager();
                    returnValue = dataManagerXmlFile.ReadData();
                    break;
                case Datasource.Database:
                    Database.DataManager dataManagerDatabase = new Database.DataManager();
                    returnValue = dataManagerDatabase.ReadData();
                    break;
                default:
                    break;

            }
            
            DataManager dataManager = new DataManager();
            returnValue = dataManager.ReadData();
            return returnValue;
        }
    }
}
