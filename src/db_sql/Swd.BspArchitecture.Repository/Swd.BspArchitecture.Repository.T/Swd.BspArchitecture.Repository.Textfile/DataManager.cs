using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Swd.BspArchitecture.Repository.Textfile
{
    public class DataManager
    {
        public string ReadData()
        {
           
            string returnValue = string.Empty;
            string filePath = Properties.Settings.Default.PathToTextfile;
            
            string fileName = "Repository.txt";
            string pathToFile = @"C:\mycode\sw_developer_2021_damian\src\Swd.Daten";

            /*
            //Stellt sicher das der Path passt also mit \ und fügt hintern die Datei dran.
            string completePath = Path.Combine(pathToFile, fileName);
            //Einen Temporären Pfad bekommen
            string temporarayPath = Path.GetTempPath();
            //Erzeugt einen Zufälligen Datei Namen welcher in dem Speicherziel nicht vorhanden ist.
            string randomFile = Path.GetRandomFileName();
            //Extenstion einer Datei bekommen (.txt, .pdf, ...)
            string extension = Path.GetExtension(completePath);
            //Dateiname bekommen
            string fileName2 = Path.GetFileName(completePath);
            //Pfad bekommen
            string pathToFile2 = Path.GetDirectoryName(completePath);

            //für Zerzeichnisse und Dateien sollte immer mit Methoden und nicht mit irgendwelchen string gearbeitet werden.
            //Dafür gibt es die Klassen, Directory und DirectoryInfo
            Directory.CreateDirectory(pathToFile);
            DirectoryInfo dir = new DirectoryInfo(pathToFile);
            File.Create(pathToFile);
            FileInfo file = new FileInfo(pathToFile);
            */

            if (File.Exists(filePath))
            returnValue = System.IO.File.ReadAllText(filePath);
            return returnValue;
            //oder return "Hello world";
        }
    }
}
