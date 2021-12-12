using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.Types
{
    public interface IPlaylist
    { 
        /// <summary>
        /// Noch schreiben
        /// </summary>
        string Name { get; }
        string Author { get; }
        DateTime CreateDate { get; }
        TimeSpan Duration { get; }
        IEnumerable<IPlaylistItem> Items { get; }
        void Add(IPlaylistItem newItem);
        void Remove(IPlaylistItem itemToRemove);
        void Clear();
    }
    
}
