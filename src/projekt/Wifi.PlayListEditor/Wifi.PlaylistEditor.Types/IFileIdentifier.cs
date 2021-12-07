using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.Types
{
    //File Dialog
    public interface IFileIdentifier
    {
        string Extension { get; }
        string Description { get; }
        //Beispiel, Description = VBScript, Extension = *.vbs
    }
}
