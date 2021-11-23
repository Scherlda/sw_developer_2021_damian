namespace Wifi.Autoverwaltung.Core
{
    public interface IStorageBase
    {
        string Filename { get; }
        

        bool Write(Fahrzeug[] vehiclesToStore);

         Fahrzeug[] Read();
        
    }
}
