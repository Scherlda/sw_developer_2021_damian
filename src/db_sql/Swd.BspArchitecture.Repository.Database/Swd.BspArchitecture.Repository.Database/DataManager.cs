using Swd.BspArchitecture.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.BspArchitecture.Repository.Database
{
    public class DataManager
    {        public string ReadData()
        {
            string returnValue = string.Empty;

            

            Bsp_ArchitectureEntities db = new Bsp_ArchitectureEntities();
            
            foreach (Message item in db.Messages)
            {
                var t = item.AnzeigeText;
            }

            Message newMsg = new Message();
            //Der AnzeigeText Wert darf nur einmal vorhanden sein, wenn der Wert bereits in der DB ist dann kommt ein Fehler
            newMsg.AnzeigeText = "Test1";
            newMsg.Sichtbar = true;

            db.Messages.Add(newMsg);
            db.SaveChanges();

            Message newMessage = db.Messages.FirstOrDefault();
            returnValue = newMessage.AnzeigeText;

            return returnValue;
            //oder return "Hello world";
        }
    }
}
