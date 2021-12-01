using BookManager.StorageTypes.XmlHelperTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookManager.StorageTypes
{
    internal class XmlStorage : IStorage
    {
        public IEnumerable<IBook> Load(string filename)
        {
            //IEnumerable<
            //XmlSerializer serializer = new XmlSerializer(typeof(Item));

            //StreamReader reader = new StreamReader(filename);
            // serializer.Deserialize(reader);
            
        }

        public bool Save(IEnumerable<IBook> dataToSave, string filename)
        {
            var items = new List<Item>();
            var xmlRoot = new ItemListRoot();
            foreach (var book in dataToSave)
            {
                var item = new Item();
                item.Titel = book.Title;
                item.Autor = book.Autor;
                item.Publisher = book.Publisher;
                item.AgeRecommendation = book.AgeRating;
                item.Language = book.Languages;
                item.YearOfPublication = book.YearOfPublication;

                items.Add(item);
            }

            xmlRoot.Item = items.ToArray();

            using (var sw = new StreamWriter(filename, false))
            {
                var serializer = new XmlSerializer(typeof(ItemListRoot));
                serializer.Serialize(sw, xmlRoot);
            }
            return true;
        }
    }
}
