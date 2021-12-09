using PlaylistsNET.Content;
using PlaylistsNET.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Wifi.PlaylistEditor.Factories;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.Repositories
{
    /// <summary>
    /// https://de.wikipedia.org/wiki/M3U
    /// </summary>
    public class M3uRepository : IRepository
    {
        private const string DATE_FORMAT_STRING = "yyyy-MM-dd";
        private const string NAME_COMMENT_KEY = "PLAYLIST-Name: ";
        private const string AUTHOR_COMMENT_KEY = "PLAYLIST-Autor: ";
        private const string CREATEDATE_COMMENT_KEY = "PLAYLIST-CreatedAt: ";
        private IPlaylistItemFactory _itemFactory;


        public string Extension => ".m3u";

        public string Description => "M3U Playlist Format";


        public IPlaylist Load(string filePath)
        {
            var contentString = string.Empty;

            if (string.IsNullOrEmpty(filePath))
            {
                return null;
            }

            filePath = FixFilePathExtension(filePath);

            //read file content and create a entity object
            using (var stream = new StreamReader(filePath))
            {
                contentString = stream.ReadToEnd();
            }
            var content = new M3uContent();
            var m3uplaylist = content.GetFromString(contentString);

            //convert
            IPlaylist playlist = MapToDomain(m3uplaylist);

            return playlist;
        }

        public bool Save(IPlaylist playlist, string filePath)
        {
            if (playlist == null || string.IsNullOrEmpty(filePath))
            {
                return false;
            }

            filePath = FixFilePathExtension(filePath);

            //convert
            M3uPlaylist m3uplaylist = MapToEntity(playlist);

            //create filecontent and write
            var content = new M3uContent();
            var stringContent = content.ToText(m3uplaylist);

            using (var sw = new StreamWriter(filePath, false))
            {
                sw.WriteLine(stringContent);
            }

            return true;
        }

        private IPlaylist MapToDomain(M3uPlaylist m3uplaylist)
        {
            //die Kommentare werden leider in einem Item abgelegt und nicht in der Playlist Ebene
            var comments = m3uplaylist.PlaylistEntries.SelectMany(e => e.Comments);
            if (!comments.Any())
            {
                return null;
            }

            var name = GetCommentValue<string>(comments, NAME_COMMENT_KEY);
            var autor = GetCommentValue<string>(comments, AUTHOR_COMMENT_KEY);
            var createDate = GetCommentValue<DateTime>(comments, CREATEDATE_COMMENT_KEY);

            var playlist = new Playlist(name, autor, createDate);
            foreach (var m3uItem in m3uplaylist.PlaylistEntries)
            {
                //var item = //Instanz einer IPlaylistItem Implementierung, aber welche?
                var item = _itemFactory.Create(m3uItem.Path);

                if (item != null)
                {
                    playlist.Add(item);
                }
            }

            return playlist;
        }

        private static M3uPlaylist MapToEntity(IPlaylist playlist)
        {
            var m3uplaylist = new M3uPlaylist();
            m3uplaylist.IsExtended = true;

            m3uplaylist.Comments.Add($"{AUTHOR_COMMENT_KEY}{playlist.Autor}");
            m3uplaylist.Comments.Add($"{NAME_COMMENT_KEY}{playlist.Name}");
            m3uplaylist.Comments.Add($"{CREATEDATE_COMMENT_KEY}{playlist.CreateDate.ToString(DATE_FORMAT_STRING)}");

            foreach (var item in playlist.Items)
            {
                var newM3uItem = new M3uPlaylistEntry
                {
                    AlbumArtist = item.Artist,
                    Title = item.Title,
                    Path = item.Path,
                    Duration = item.Duration,
                };

                m3uplaylist.PlaylistEntries.Add(newM3uItem);
            }

            return m3uplaylist;
        }

        private string FixFilePathExtension(string filePath)
        {
            var fi = new FileInfo(filePath);
            if (fi.Extension != Extension)
            {
                if (!string.IsNullOrEmpty(fi.Extension))
                {
                    filePath = filePath.Replace(fi.Extension, Extension);
                }
                else
                {
                    filePath = filePath + Extension;
                }
            }

            return filePath;
        }

        private T GetCommentValue<T>(IEnumerable<string> comments, string key)
        {
            T result = default(T);

            var value = comments.FirstOrDefault(x => x.StartsWith(key));
            if (value != null)
            {
                value = value.Replace(key, string.Empty);
                switch (typeof(T).Name)
                {
                    case "String":
                        result = (T)Convert.ChangeType(value, typeof(T));
                        break;

                    case "DateTime":
                        var convertedValue = DateTime.ParseExact(value, DATE_FORMAT_STRING, CultureInfo.InvariantCulture);
                        result = (T)Convert.ChangeType(convertedValue, typeof(T));
                        break;
                }
            }

            return result;
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Wifi.PlaylistEditor.Types;
//using System.Drawing;

//namespace Wifi.PlaylistEditor.Repositories
//{
//    public delegate string AReturn();
//    /// <summary>
//    /// https://de.wikipedia.org/wiki/M3U#:~:text=%23EXTM3U%0A%23EXTINF%3A221,musik/titel4.mp3
//    /// Für PLS
//    /// https://de.wikipedia.org/wiki/PLS_(Dateiformat) 
//    /// </summary>
//    public class M3uRepository : IRepository
//    {
//        private string _extension;
//        private string _description;

//        public M3uRepository()
//        {
//            _extension = "*.m3u";
//            _description = "Playlist Datei";
//        }
//        public string Extension
//        {
//            get { return _extension; }
//        }


//        public string Description
//        {
//            get { return _description; }
//        }

//        public IPlaylist Load(string filePath)
//        {
//            var result = M3UParser.M3UParser.parse(File.ReadAllLines(filePath));
//            IPlaylist playlist = new Playlist("Playlist Test", "Autor Test");

//            foreach (var item in result)
//            {

//                var artist = item.Title.Split(new Char[] { '-' })[0].Trim();
//                var title = item.Title.Split(new Char[] { '-' })[1].Trim();

//                var playlistItem = new PlaylistItem(title, artist, TimeSpan.FromSeconds(item.Duration), item.Location);
//                playlist.Add(playlistItem);
//            }

//            return playlist;
//        }

//        public bool Save(IPlaylist playlist, string filepath)
//        {
//            if (playlist == null || (playlist.Items.ToList().Count == 0 ))
//                { return false; }


//            string m3uFile = $"#EXTM3U{Environment.NewLine}";


//            foreach (var item in playlist.Items)
//            {
//                m3uFile += $"#EXTINF:{item.Duration.TotalSeconds},{item.Artist} - {item.Title}{Environment.NewLine}";
//                m3uFile += $"{item.Path}{Environment.NewLine}";

//            }

//            var pathToSave = Path.Combine(filepath, playlist.Name + ".m3u");
//            try
//            {
//                File.WriteAllText(pathToSave, m3uFile);
//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//            }

//        }
//    }
//}
