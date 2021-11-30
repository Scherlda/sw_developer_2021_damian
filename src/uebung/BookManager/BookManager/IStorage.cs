using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    public interface IStorage
    {
        List<IBook> Load(string filename);

        bool Save(List<IBook> dataToSave, string filename);
    }
}
