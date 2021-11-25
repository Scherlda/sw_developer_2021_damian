using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsGL
{
    internal interface IStorage
    {
        //Dümmste Liste in C#, kann weniger als Array. Listen = Collections
        //IEnumerable ist der Urtyp aller Listen und Arrays
        //Listen sind immer <>, [] = Array
        IEnumerable<IBook> Load(string filename);

        bool Save (IEnumerable<IBook> dataToSave, string filename);
    }
}
