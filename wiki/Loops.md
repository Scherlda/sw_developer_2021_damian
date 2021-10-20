# Schleifen
Schleifen dienen dem wiederholen von Code solange eine bestimmte Bedinung nicht erfüllt ist.

### For-Schleife

Die for-Schleife definiert zunächst einen Wert, überprüft diesen dann und verändert diesen nach einmaliger ausführung der Schleife.

Wird meistens verwendet wenn die Anzahl an wiederholungen bekannt ist.

Aufbau

Initialiserung; Abbruchbedingung; Reinitialisierung;

```csharp
// i ist der Wert mit welchem gearbeitet wird solange wie i kleiner 5 ist.
// nach jedem Schleifen durchlauf wird i++ (erhöht i um 1) ausgeführt, solange bis
// die Abbruchbedingung erfüllt ist. 

for(int i = 1; i < 5; i++);
	{
		Console.WriteLine("Zähler ist {0}", i);
	}
```

### While / do-while

Mit der while Schleife wird zuerst geprüft ob die Bedingung die gestellt wurde bereits erfüllt ist und je nach dem wird der Inhalt ausgefürt, während die do-while Schleife zunächst den Code ausführt und dann überprüft ob die Bedingung bereits erfüllt ist.

Beispiel

```csharp
int zahl = 4;        

//Ist der Wert bereits erfüllt do wird es nicht ausgeführt
while(zahl < DateTime.Now.Second)
{
    Console.WriteLine(DateTime.Now.Second);
    Thread.Sleep(1000);
}

//Wird zuerst ausgeführt und erst dann wird geprüft ob der Wert erfüllt ist.
do
{
    Console.WriteLine($"do-while: {DateTime.Now.Second}");
    Thread.Sleep(1000);

} while (zahl < DateTime.Now.Second);
```