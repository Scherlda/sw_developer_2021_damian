using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    public interface IStorage
    {
        IEnumerable<IBook> Load(string filename);

        bool Save(IEnumerable<IBook> dataToSave, string filename);
    }
}
