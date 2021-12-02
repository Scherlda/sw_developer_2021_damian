using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.Types
{
    internal class IPlayListItem
    {
        string Title { get; }
        string Artist { get; }
        TimeSpan Duration { get; }
        string Path { get; }
        Image Thumbnail { get; }
    }
}
