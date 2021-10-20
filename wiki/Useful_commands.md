# N�tzliche Befehle
### Mehrfach Deklaration Datentypen

Es k�nnen auch mehrere Datentypen in einer Zeile deklariert werden

```csharp
int wert1, wert2, wert3, wert4
```


### Datum/Zeit

Mit dem Befehl DateTime kann mit der Zeit gearbeitet werden. Zudem kann mit DateTime �hnlich wie mit einem int gearbeitet werden.

Beispiele

In der ersten Zeile wird das jetztige Datum und die Uhrzeit festgehalten.

In der zweiten Zeile das was der User eingibt. (Es muss nicht Datum und Uhrzeit eingegeben werden. Kommt nur das Datum bleibt die Zeit einfach 00:00:00)

```csharp
DateTime beispielDatum = DateTime.Now;
beispielDatum = DateTime.Parse(Console.ReadLine());
```

Genauso kann dann mit der gestzen Variable gearbeitet werden.
In diesem Beispiel wird das Datum in einen String mit bestimmten Vorgaben konvertiert.

```csharp
Console.WriteLine($"{beispielDatum.ToString("ddMMyy")}")
```
### Sleep (Warten)

Mit dem Befehl Thread.Slepp(1000) kann die aktuelle aktion f�r eine bestimmte Zeit angehalten werden. In diesem fall 1000 = 1 Sekunde.

Hierf�r muss allerding das using System.Threading hinzugef�rt werden.

```csharp
Console.WriteLine("Bitte warten");
Thread.Sleep(1000);
Console.WriteLine("Hallo");
```