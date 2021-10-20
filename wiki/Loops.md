# Schleifen
Schleifen dienen dem wiederholen von Code solange eine bestimmte Bedinung nicht erf�llt ist.

### For-Schleife

Die for-Schleife definiert zun�chst einen Wert, �berpr�ft diesen dann und ver�ndert diesen nach einmaliger ausf�hrung der Schleife.

Wird meistens verwendet wenn die Anzahl an wiederholungen bekannt ist.

Aufbau

Initialiserung; Abbruchbedingung; Reinitialisierung;

```csharp
// i ist der Wert mit welchem gearbeitet wird solange wie i kleiner 5 ist.
// nach jedem Schleifen durchlauf wird i++ (erh�ht i um 1) ausgef�hrt, solange bis
// die Abbruchbedingung erf�llt ist. 

for(int i = 1; i < 5; i++);
	{
		Console.WriteLine("Z�hler ist {0}", i);
	}
```

### While / do-while

Mit der while Schleife wird zuerst gepr�ft ob die Bedingung die gestellt wurde bereits erf�llt ist und je nach dem wird der Inhalt ausgef�rt, w�hrend die do-while Schleife zun�chst den Code ausf�hrt und dann �berpr�ft ob die Bedingung bereits erf�llt ist.

Beispiel

```csharp
int zahl = 4;        

//Ist der Wert bereits erf�llt do wird es nicht ausgef�hrt
while(zahl < DateTime.Now.Second)
{
    Console.WriteLine(DateTime.Now.Second);
    Thread.Sleep(1000);
}

//Wird zuerst ausgef�hrt und erst dann wird gepr�ft ob der Wert erf�llt ist.
do
{
    Console.WriteLine($"do-while: {DateTime.Now.Second}");
    Thread.Sleep(1000);

} while (zahl < DateTime.Now.Second);
```