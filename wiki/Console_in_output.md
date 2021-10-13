## Textausgabe

Auf der Console kann Text mit WriteLine ausgeben werden.

```csharp
Console.WriteLine("Ich bin ein Text")
```

### Textausgabe beeinflussen

\n ⇒ Neue Zeile

\t ⇒ Ein Tabulator sprung

\a ⇒ Alert, das System gibt einen Ton aus

```csharp
Console.WriteLine("Hallo\n\tHier!\a")
```

Ausgabe

```
Hallo
			Hier! (+ Windows benachrichtigungston)
```

### Sonderzeichen in der Ausgabe ausgeben

Manche Zeichen unterbrechen die Ausgabe.
Möchte ich jetzt dennoch ein " oder ein \ in meiner Ausgabe enthalten haben kann dies mit einem \ vor dem jeweiligen Zeichen, oder ein @ zu beginn der "" anforderung angehängt werden.

Beispiele

```csharp
Console.WriteLine(@"Mein\nName")
string speicherort = @"C:\path\to\file"
```

## Eingabe

Möchte man jetzt mit dem User interagieren, so sollte dieser auch etwas retour melden können.
für diesen Fall gibt es das Console.Read.Line(). Dieser Befehl nimmt den vom User eingegeben Text und speichert ihn in eine Variable welche vorher zumindest deklariert werden muss.

```csharp
string Name;
Name = Console.ReadLine();
```