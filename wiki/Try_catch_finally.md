# Try/Catch/Finally - Abfangen von Fehlern
Mit Try and Catch können Fehler abgefangen und ausgegeben werden, so kann verhindert werden das, dass Program abstürzt.

Der Finally block wird immer ausgeführt, egal ob try/catch einen Error hatte oder nicht. 

```csharp
try
{
		//Hier kommt der Code welcher seiner laufzeit einen Fehler verursachen könnte
}
catch (Exception)
{
		//Hier wird kommt Code welcher ausgeführt wird wenn in try ein Fehler vorkommt
}
finally
{
		//Code der immer ausgeführt wird, egal ob der Code fehlerhaft ware oder nicht
		//Wenn eine Verbindung zu einer Datei oder Server aufgebaut wurde kann diese so immer geschlossen werden
}
```

Es können auch bestimmte Fehlertypen abgefangen und ausgeben werden.
Sollte keinFehlertyp mit dem Fehler überein stimmen kann immer noch die Standart Exception ausgegeben werden.
Wird nichts eingegeben so kann eine ArgumentNull Exception ausgegeben werden 

Sollte der Wert überlaufen so kann eine Overflow Exception ausgegeben werden, usw

Beispiel mit einem Format Error

```csharp
Console.WriteLine("Bitte gib eine Zahl ein");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException) //Sollte Text statt einer Zahl eingegeben werden
            {
                Console.WriteLine("Format war inkorrekt. Du hättest eine Nummer eintragen sollen!");
            }
            catch (ArgumentException) //Es wurde nichts eingegeben
            {
                Console.WriteLine("ArgumentNullExpetion, der Wert war leer (null)");
            }
            catch (OverflowException) //Der einegebene Wert ist zu groß für einen Int
            {
                Console.WriteLine("Der eingegebene Wert war zu groß");
            }
            catch (Exception)
            {
                Console.WriteLine("Ein anderer Fehler");
            }
            finally
            {
                Console.WriteLine("Ich werde immer ausgeführt");
            }
						
```

Ist eine Exeption nicht angeführt kann beim Absturz des Programs in Visual Studio immer ausgelesen werden was für ein Fehler es war.