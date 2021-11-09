using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.ConsoleTools.Misc;

namespace OOP_Grundlagen
{
    class Mitarbeiter
    {
        private Guid _id; //
        private string _name;
        private Gender _geschlecht;
        private DateTime _birthday;


        //std. Konstruktor
        //public Mitarbeiter()
        //{
        //    Id = Guid.NewGuid();
        //    Geschlecht = Gender.Undefined;
        //    Name = "No Name_" + Id;
        //}

        //Benutzerspezifischer Konstruktor (überladung, die singatur also das in der () muss eindeutig sein)
        public Mitarbeiter(string name, Gender geschlecht, DateTime birthday)
        {
            _id = Guid.NewGuid();
            _geschlecht = geschlecht;
            _name = name;
            _birthday = birthday;
        }
        public Mitarbeiter(Guid id, string name, Gender geschlecht, DateTime birthday)
        {
            _id = id;
            _geschlecht = geschlecht;
            _name = name;
            _birthday= birthday;
        }

        //Änderungs- und Zugriffsmethoden
        //public string GetName()
        //{
        //    return Name;
        //}

        //public Gender GetGeschlecht()
        //{
        //    return Geschlecht;
        //}

        //public Guid GetId()
        //{
        //    return Id; 
        //}

        //public void SetId(Guid newId)
        //{
        //    if (newId != Guid.Empty)
        //    {
        //        Id = newId;
        //    }
        //}
        
        /*Eigenschaft, Eigneschaften sind nur Zustandsinformationen*/
        public Guid Id
        {
            get { return _id; }
        }
        public string Name  //Hier wird nur ein get definiert, so kann nur der Name ausgelesen aber nicht gesetzt werden, dafür ist die ChangeName Metohde da.
        {
            get
            {
                return _name;
            }
        }

        public Gender Geschlecht
        {
            get { return _geschlecht; }
            set { _geschlecht = value; }
        }
        public void ChangeName(string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                _name = newName;
            }
        }

        public void DisplayInfos()
        {
            Console.WriteLine($"ID:     [{_id}]");
            Console.WriteLine($"Name    {_name}");
            Console.WriteLine($"Gender: {_geschlecht}");
        }
    }
}
