using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.StorageTypes
{
    internal class JsonStorage : IStorage
    {
        public IEnumerable<IBook> Load(string filename)
        {
            string jsonString = string.Empty;
            using (var sr = new StreamReader(filename))
            {
                jsonString = sr.ReadToEnd();
            }

            var bookList = JsonConvert.DeserializeObject<IEnumerable<Book>>(jsonString);
            return bookList;
        }

        public bool Save(IEnumerable<IBook> dataToSave, string filename)
        {
            var JsonString = JsonConvert.SerializeObject(dataToSave);

            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                sw.WriteLine(JsonString);
            }

            return true;
        }

    }
}
