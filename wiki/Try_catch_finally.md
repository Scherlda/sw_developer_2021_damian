# Try/Catch/Finally - Abfangen von Fehlern
Mit Try and Catch k�nnen Fehler abgefangen und ausgegeben werden, so kann verhindert werden das, dass Program abst�rzt.

Der Finally block wird immer ausgef�hrt, egal ob try/catch einen Error hatte oder nicht. 

```csharp
try
{
		//Hier kommt der Code welcher seiner laufzeit einen Fehler verursachen k�nnte
}
catch (Exception)
{
		//Hier wird kommt Code welcher ausgef�hrt wird wenn in try ein Fehler vorkommt
}
finally
{
		//Code der immer ausgef�hrt wird, egal ob der Code fehlerhaft ware oder nicht
		//Wenn eine Verbindung zu einer Datei oder Server aufgebaut wurde kann diese so immer geschlossen werden
}
```

Es k�nnen auch bestimmte Fehlertypen abgefangen und ausgeben werden.
Sollte keinFehlertyp mit dem Fehler �berein stimmen kann immer noch die Standart Exception ausgegeben werden.
Wird nichts eingegeben so kann eine ArgumentNull Exception ausgegeben werden 

Sollte der Wert �berlaufen so kann eine Overflow Exception ausgegeben werden, usw

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
                Console.WriteLine("Format war inkorrekt. Du h�ttest eine Nummer eintragen sollen!");
            }
            catch (ArgumentException) //Es wurde nichts eingegeben
            {
                Console.WriteLine("ArgumentNullExpetion, der Wert war leer (null)");
            }
            catch (OverflowException) //Der einegebene Wert ist zu gro� f�r einen Int
            {
                Console.WriteLine("Der eingegebene Wert war zu gro�");
            }
            catch (Exception)
            {
                Console.WriteLine("Ein anderer Fehler");
            }
            finally
            {
                Console.WriteLine("Ich werde immer ausgef�hrt");
            }
						
```

Ist eine Exeption nicht angef�hrt kann beim Absturz des Programs in Visual Studio immer ausgelesen werden was f�r ein Fehler es war.