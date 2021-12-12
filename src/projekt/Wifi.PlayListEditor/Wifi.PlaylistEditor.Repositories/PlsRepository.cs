using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.Repositories
{
    internal class PlsRepository : IRepository
    {
        public string Extension => ".pls";

        public string Description => "PLS Playlist Format";

        public IPlaylist Load(string filePath)
        {
            throw new NotImplementedException();
        }

        public bool Save(IPlaylist playlist, string FilePath)
        {
            if (playlist == null || string.IsNullOrEmpty(FilePath))
            {
                return false;
            }

            return true;
        }
    }
}
