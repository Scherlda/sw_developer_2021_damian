using System.Collections;
using System.Collections.Generic;
//using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.Types
{
    public interface IRepositoryFactory
    {
        IEnumerable<IFileIdentifier> AvailableTypes { get; }
        IRepository Create(string fileName);
    }
}