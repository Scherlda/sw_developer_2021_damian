using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Types;
using System.Drawing;

namespace Wifi.PlaylistEditor.Repositories
{
    public delegate string AReturn();
    /// <summary>
    /// https://de.wikipedia.org/wiki/M3U#:~:text=%23EXTM3U%0A%23EXTINF%3A221,musik/titel4.mp3
    /// Für PLS
    /// https://de.wikipedia.org/wiki/PLS_(Dateiformat) 
    /// </summary>
    public class M3uRepository : IRepository
    {
        private string _extension;
        private string _description;

        public M3uRepository()
        {
            _extension = "*.m3u";
            _description = "Playlist Datei";
        }
        public string Extension
        {
            get { return _extension; }
        }
        

        public string Description
        {
            get { return _description; }
        }

        public IPlaylist Load(string filePath)
        {
            var result = M3UParser.M3UParser.parse(File.ReadAllLines(filePath));
            IPlaylist playlist = new Playlist("Playlist Test", "Autor Test");

            foreach (var item in result)
            {
                var artist = item.Title.Split(new Char[] { '-' })[0].Trim();
                var title = item.Title.Split(new Char[] { '-' })[1].Trim();

                var playlistItem = new PlaylistItem(title, artist, TimeSpan.FromSeconds(item.Duration), item.Location);
                playlist.Add(playlistItem);
            }

            return playlist;
        }

        public bool Save(IPlaylist playlist)
        {
            if (playlist == null || (playlist.Items.ToList().Count == 0 ))
                { return false; }
                

            string m3uFile = $"#EXTM3U{Environment.NewLine}";


            foreach (var item in playlist.Items)
            {
                m3uFile += $"#EXTINF:{item.Duration.TotalSeconds},{item.Artist} - {item.Title}{Environment.NewLine}";
                m3uFile += $"{item.Path}{Environment.NewLine}";
                    
            }

            var pathToSave = Path.Combine(@"C:\mycode\sw_developer_2021_damian\src\projekt\Wifi.PlayListEditor\playlist_files", playlist.Name + ".m3u");
            try
            {
                File.WriteAllText(pathToSave, m3uFile);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
