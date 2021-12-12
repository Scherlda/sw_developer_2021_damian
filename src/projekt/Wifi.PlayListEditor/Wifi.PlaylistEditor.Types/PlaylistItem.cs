using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.Types
{
    public class PlaylistItem : IPlaylistItem
    {
        private string _title;
        private string _artist;
        private TimeSpan _duration;
        private string _path;
        private Image _thumbnail;

        public PlaylistItem(string title, string artist, TimeSpan duration, string path, Image thumbnail)
            :this(title, artist, duration, path)
        {
            _thumbnail = thumbnail;
        }

        public PlaylistItem(string title, string artist, TimeSpan duration, string path)
        {
            _title = title;
            _artist = artist;
            _duration = duration;
            _path = path;

            //sample image
            string pathToSamplePng = @"C:\mycode\sw_developer_2021_damian\src\projekt\Wifi.PlayListEditor\Wifi.PlaylistEditor.Types\pic\sample_image.png";
            _thumbnail = Image.FromFile(pathToSamplePng);
        }

        public string Title
        {
            get { return _title; }
        }

        public string Arthist
        {
            get { return _artist; }
        }
        public TimeSpan Duration
        {
            get { return _duration; }
        }
        public string Path
        {
            get { return _path; }
        }
        public Image Thumbnail
        {
            get { return _thumbnail; }
        }
    }
}
