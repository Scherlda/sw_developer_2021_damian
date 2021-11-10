# Array

Arrays gehören zu den Datenstrukturen. Datenstrukturen sind Sammlungen von Daten, die jeweils auf die verschiedenste Art und Weise mit diesen Daten umgehen. Die einfachste Datenstruktur in der Programmierung ist der Array. Er stellt nebenbei bemerkt
auch die Grundlage für alle anderen Datenstrukturen dar.

Ein Array ist eine Variable in welche statt nur einem, mehrere Werte hineingespeichert werden können. Diese Werte können über einen Idx gelsen, beschrieben oder auch überschrieben werden.

Für die Initialisierung wird das Schlüsselwort new verwendet. Anschließend wird in der eckigen Klammer der Index Wert angeben, so kann dem Wert eine eindeutige ID gegeben werden.

![Untitled](Array%20327bcaa73836467c94aa07eba76a4740/Untitled.png)

## Mehrdimensionale Arrays

Im Beispiel oben sehen wir einen sogenannten 1-Dimensionalen Array. Ein 1D-Array ist dasselbe wie eine ganz normale einfache Auflistung. Neben diesen gibt es aber auch noch mehrdimensionale Arrays. Ich möchte hier allerdings nur noch auf die 2D-Arrays eingehen, da man nur diese wirklich in der Praxis benötigt. Ein 2D-Array kann man sich wie eine Tabelle vorstellen. Während man mit nur einer Dimension in einem 1D-Array eine einfache Liste hat, haben wir bei zwei Dimensionen eine Tabelle mit Zeilen und Spalten.

![Untitled](Array%20327bcaa73836467c94aa07eba76a4740/Untitled%201.png)

## Struct Array

Im Struct Array wird zunächst ein struct (eventuell auch in einer eigenen Datei) angelegt.

```csharp
struct Teilnehmer //Teilnehmer ist der Datentyp
{
		public string Name;
    public DateTime GeburtsDatum;
    public int Plz;
}
```

Befüllen und ausgeben des Arrays

```csharp
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
```