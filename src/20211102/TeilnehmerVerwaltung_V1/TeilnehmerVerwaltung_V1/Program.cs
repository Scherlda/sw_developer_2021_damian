using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.ConsoleTools;

namespace TeilnehmerVerwaltung_V1
{
    /*
     *  Teilnehmer Verwaltung v0.2
     * 
     * - Name
     * - Gebrutsdatum
     * - PLZ
     * 
     * 
     */

 
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Teilnehmer[] listOfAttendees;


            //Eingabe der Anzahl von Teilnehmern
            Console.Write("Bitte Anzahl der Zeilnemer eingeben: ");
            count = int.Parse(Console.ReadLine());

            //Dimensionierung der Liste
            listOfAttendees = new Teilnehmer[count];

            //Eingabe der Daten
            for (int i = 0; i < count; i++)
            {
                listOfAttendees[i] = new Teilnehmer();

                Console.Write($"\t\tName Teilnehmer {i +1}: ");
                listOfAttendees[i].Name = Console.ReadLine();
                Console.Write($"\tGeburtsdatum Teilnehmer {i + 1}: ");
                listOfAttendees[i].GeburtsDatum = DateTime.Parse(Console.ReadLine());
                Console.Write($"\tPostleitzahl Teilnehmer {i + 1}: ");
                listOfAttendees[i].Plz = Wifi.ConsoleTools. //int.Parse(Console.ReadLine());

            }

            
            //Ausgabe der Daten
            foreach (Teilnehmer oneAttendee in listOfAttendees)
            {
                Console.WriteLine(oneAttendee.Name);
                Console.WriteLine(oneAttendee.GeburtsDatum);
                Console.WriteLine(oneAttendee.Plz);
            }
            Console.ReadKey();
        }
    }
}
