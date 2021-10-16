# If-Else Entscheidungen treffen

Mit if und else können entscheidungen getroffen werden.
So kann je nach Wert ein anderer Code ausgeführt werden.

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

Werte überprüfung mit Fehlerverhinderung

In einer if Abfrage kann mit dem Operator TryParse gearbeitet werden um Fehler im vorhinien abzufangen.

Der TryParse befehl ist dabei wie folgt aufgebaut

(%zieloperator%.TryParse(%zu_überprüfende_variable%, out %variable_in_welche_der_wert_bei_richtigkeit_übergeben_wird%))

Kommt kein Fehler zustande so wird der Wert in number übergeben, mit welchem dann auch weiterhin gearbeitet werden kann.

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

Alternativ könnte auch zuerst ein bool angelegt und der Wahrheitswert in diesen gespeichert werden.

```csharp
bool userEnterdANumber = double.TryParse(temperatureInput, out number)
```

## Prüfung ketten

Bei der If Abfrage können auch mehrere Werte auf einmal überprüft werden.

```csharp
if (werta == 1 && wert2 == "Beispiel" && wert3 != false)
{
	Console.WriteLine("Werte erfüllt");
}
//Hier prüfen wir ob wert1 und wert2 erfüllt sind oder stattdessen wert 3
else if (wert1 == 1 && wert2 == "Beispiel" || wert3 == true)
{
	Console.WriteLine("Nur wert3 ist erfüllt, das reicht aber")
}
```

# Verschachtelte If-Statements

If-Abfragen können auch mehrmals ineinander geschehen, dies ist sehr nützlich bei mehrfach entscheidungen.

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

Im Folgenden Beispiel wird ein string je nach dem ob der Wert temperature kleiner als 0 oder größer als 0 ist, befüllt.
Der string vor den ":" wird an den stateOfMatter string übergeben wenn die prüfung true ist, ansonsten wird der zweite Wert hineingegeben (false).

 

```csharp
double temperature = 101
string stateOfMatter;
stateOfMatter = temperature < 0 ? "fest" : "flüssig";
```

Dies funktioniert auch wenn noch ein Wert geprüft werden muss (if else).

Jetzt wird zunächst geprüft ob temperature 100 grad heiß ist, wenn nicht (:) dann wird geprüft ob diese < 0 grad ist, wenn nicht dann wird flüssig ausgegeben, 

```csharp
double temperature = 101
string stateOfMatter;
stateOfMatter = temperature > 100 ? "gas" : (temperature < 0 ? "fest" : "flüssig");
```