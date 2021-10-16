#If-Else Entscheidungen treffen

Mit if und else k�nnen entscheidungen getroffen werden.
So kann je nach Wert ein anderer Code ausgef�hrt werden.

### Grundstruktur

```csharp
double temperatur = 10;

if (temperatur < 10)
{
	Console.WriteLine("Zieh deine Jacke an");
}
else if(temperatur == 10)
{
	Console.WriteLine("Es ist genau 10 Grad warm");
}
else if(temperatur > 10)
{
	Console.WriteLine("T-Shirt reicht heute aus");
}
```

Werte �berpr�fung mit Fehlerverhinderung

In einer if Abfrage kann mit dem Operator TryParse gearbeitet werden um Fehler im vorhinien abzufangen.

Der TryParse befehl ist dabei wie folgt aufgebaut

(%zieloperator%.TryParse(%zu_�berpr�fende_variable%, out %variable_in_welche_der_wert_bei_richtigkeit_�bergeben_wird%))

Kommt kein Fehler zustande so wird der Wert in number �bergeben, mit welchem dann auch weiterhin gearbeitet werden kann.

```csharp
string UserInput;
double temperature;
double number;

Console.WriteLine("Wie warm ist es gerade, trag bitte die aktuelle Temperatur ein:");
UserInput = Console.ReadLine();

if (double.TryParse(UserInput, out number))
{
    temperature = number;
}
else
{
    temperature = 0;
}
```

Alternativ k�nnte auch zuerst ein bool angelegt und der Wahrheitswert in diesen gespeichert werden.

```csharp
bool userEnterdANumber = double.TryParse(temperatureInput, out number)
```

## Pr�fung ketten

Bei der If Abfrage k�nnen auch mehrere Werte auf einmal �berpr�ft werden.

```csharp
if (werta == 1 && wert2 == "Beispiel" && wert3 != false)
{
	Console.WriteLine("Werte erf�llt");
}
//Hier pr�fen wir ob wert1 und wert2 erf�llt sind oder stattdessen wert 3
else if (wert1 == 1 && wert2 == "Beispiel" || wert3 == true)
{
	Console.WriteLine("Nur wert3 ist erf�llt, das reicht aber")
}
```

# Verschachtelte If-Statements

If-Abfragen k�nnen auch mehrmals ineinander geschehen, dies ist sehr n�tzlich bei mehrfach entscheidungen.

```csharp
string value1 = "5";
int number1;
bool stringIsANumber = int.TryParse(value1, out number1);

if(stringIsANumber == true)
{
	if(number1 == 5)
	{
		Console.WriteLine("Yeay es ist 5");
	}
}
```

## Erweitere If-Statements

### Kurzversion If-Statement

Im Folgenden Beispiel wird ein string je nach dem ob der Wert temperature kleiner als 0 oder gr��er als 0 ist, bef�llt.
Der string vor den ":" wird an den stateOfMatter string �bergeben wenn die pr�fung true ist, ansonsten wird der zweite Wert hineingegeben (false).

 

```csharp
double temperature = 101
string stateOfMatter;
stateOfMatter = temperature < 0 ? "fest" : "fl�ssig";
```

Dies funktioniert auch wenn noch ein Wert gepr�ft werden muss (if else).

Jetzt wird zun�chst gepr�ft ob temperature 100 grad hei� ist, wenn nicht (:) dann wird gepr�ft ob diese < 0 grad ist, wenn nicht dann wird fl�ssig ausgegeben, 

```csharp
double temperature = 101
string stateOfMatter;
stateOfMatter = temperature > 100 ? "gas" : (temperature < 0 ? "fest" : "fl�ssig");
```