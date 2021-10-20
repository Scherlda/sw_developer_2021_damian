Die wichtigsten sind int f�r ganze Zahlen und double f�r Dezimalzahlen. Bei Geld und zahlen die sehr genau sein m�ssen wird der decimal verwendet. Diesen nur verwenden wenn es wirklich n�tig ist, hier wird richtig Speicher verbrennt.

Im code ist immer . das Komma!

## Ganze Zahlen

![ganze_zahlen.png](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/e633962b-f1b5-4000-a172-3704c2ab63e3/ganze_zahlen.png)

## Zahlen mit Nachkommastellen

![zahlen_nachkommastellen.png](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/a91d10a9-447e-416a-abde-584157aed456/zahlen_nachkommastellen.png)

### Decimal initialisierung

Wird ein Decimal initialisiert so muss im wert hinten ein m mitangegeben werden.

```csharp
decimal meinBudget = 455.321m;
```

## Andere Datentypen

![andere_datentypen.png](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/fe704afb-fbde-4640-bece-fc27e2076fc1/andere_datentypen.png)

### Konvertierung zwischen den Datentypen

Datentypen k�nnen auch in andere Datentypen konvertiert werden.

Aus String Konvertieren

Solch eine Konvertierung k�nnte beispielsweider mit Convert.ToInt32(zahl) oder .Parse gemacht werden.

```csharp
string textzahl= "123";
int zahl = Convert.ToInt32(textzahl);
int zahl = int zahl = int.Parse(textzahl);
```

Inplizite Konvertierung

Solange in einen h�heren/gr��eren Datentyp Konvertiert wird, kann dies Verlustlos und ohne weiteres getan werden. Hier muss nicht extra darauf hingewiesen werden das diese Konvertierung stattfinden soll.

```csharp
short kleineZahl = 123;
int grosseZahl = kleineZahl;
```

Expliziete Konvertierung

Bei der Explizieten Konvertierung wird im Normalfall in einen niedrigeren/kleineren Datentyp konvertiert. Da hier ein verlust entstehen kann muss im Code explizit angegeben werden das man dies auch wirklich tun m�chte. Daf�r wird der jeweilige Datentyp in () davor angegeben
So gehen beispielsweise komma stellen verloren.

```csharp
double grosseZahl = 123,30;
int kleineZahl = 123;
kleineZahl = (int)grosseZahl;
Console.WriteLine(kleineZahl); //Ausgabe: 123
```