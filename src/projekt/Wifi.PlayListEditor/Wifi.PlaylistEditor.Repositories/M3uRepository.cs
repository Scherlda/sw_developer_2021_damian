using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.Repositories
{
    /// <summary>
    /// https://de.wikipedia.org/wiki/M3U#:~:text=%23EXTM3U%0A%23EXTINF%3A221,musik/titel4.mp3
    /// Für PLS
    /// https://de.wikipedia.org/wiki/PLS_(Dateiformat)
    /// </summary>
    public class M3uRepository : IRepository
    {
        public string Extension => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public IPlaylist Load(string filePath)
        {
            throw new NotImplementedException();
        }

        public bool Save(IPlaylist playlist)
        {
            throw new NotImplementedException();
        }
    }
}
