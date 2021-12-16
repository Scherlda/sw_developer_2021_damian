using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Factories;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.Repositories
{
    public class JsonRepository : IRepository
    {
        private IPlaylistItemFactory _itemFactory;
        public JsonRepository(IPlaylistItemFactory itemFactory)
        {
            _itemFactory = itemFactory;
        }

        public string Extension => ".json";

        public string Description => "Export in Json file";

        public IPlaylist Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return null;
            }
            string jsonString = string.Empty;
            using (var sr = new StreamReader(filePath))
            {
                jsonString = sr.ReadToEnd();
            }

            var playList = JsonConvert.DeserializeObject<IPlaylist>(jsonString);
            return playList;
        }

        public bool Save(IPlaylist playlist, string FilePath)
        {
            if (playlist == null || string.IsNullOrEmpty(FilePath))
            {
                return false;
            }

            var JsonString = JsonConvert.SerializeObject(playlist);

            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                sw.WriteLine(JsonString);
            }

            return true;
        }
    }
}
