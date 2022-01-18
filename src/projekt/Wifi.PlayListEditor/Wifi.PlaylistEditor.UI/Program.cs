using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Wifi.PlaylistEditor.Factories;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Der Unity Container, welcher aus dem Unity nuget stammt buildet die Forms selbstständig in der richtigen Reihenfolge
            var container = new UnityContainer();

            container.RegisterType<IRepositoryFactory, IRepositoryFactory>();
            container.RegisterType<IPlaylistItemFactory, PlaylistItemFactory>();
            //Interface implementieren
            container.RegisterType<INewPlaylistCreator, frmNewPlaylist>();

            var mainForm = container.Resolve<Form>();


            Application.Run(mainForm);
        }
    }
}
