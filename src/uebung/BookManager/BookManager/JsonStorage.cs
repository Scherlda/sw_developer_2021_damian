﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    public class JsonStorage : IStorage
    {
        public List<IBook> Load(string filename)
        {
            throw new NotImplementedException();
        }

        public bool Save(List<IBook> dataToSave, string filename)
        { //if nicht vergessen
            //var _bookToSave = dataToSave;
             
            //using (StreamWriter file = File.CreateText(filename))
            //{
            //    JsonStorage serial = new JsonStorage();
                
            //}
            
            
            return true;
        }
    }
}
