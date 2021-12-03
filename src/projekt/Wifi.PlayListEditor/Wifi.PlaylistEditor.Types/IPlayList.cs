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
        string Autor { get; }
        DateTime CreateDate { get; }
        TimeSpan Duration { get; }
        IEnumerable<IPlayListItem> Items { get; }
        void Add(IPlayListItem newItem);
        void Remove(IPlayListItem itemToRemove);
        void Clear();
    }
    
}
