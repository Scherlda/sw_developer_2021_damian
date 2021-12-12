using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.Types
{
    public interface IPlaylistItem
    {
        string Title { get; }
        string Arthist { get; }
        TimeSpan Duration { get; }
        string Path { get; }
        Image Thumbnail { get; }
    }
}
