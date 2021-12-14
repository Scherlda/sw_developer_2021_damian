using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.UI
{
    public interface IRepositoryFactory
    {
        IRepository Create(string fileName);
    }
}