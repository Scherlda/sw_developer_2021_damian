using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.Types
{
    public interface IRepository : IFileIdentifier
    {
        IPlaylist Load(string filePath);

        bool Save(IPlaylist playlist);
    }
}
