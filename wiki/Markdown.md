# Markup Language

<p>Markdown ist eine vereinfachte Auszeichnungssprache, die von John Gruber und Aaron Swartz entworfen und im Dezember 2004 mit Version 1.0.1 spezifiziert wurde.
Ein Ziel von Markdown ist, dass schon die Ausgangsform ohne weitere Konvertierung leicht lesbar ist. Als Auszeichnungselemente wurden daher vor allem Auszeichnungsarten verwendet, die in Plain text und E-Mails üblich sind.
Auch andere Auszeichnungssprachen mit ähnlichen Zielen zur Lesbarkeit – wie reStructuredText oder Textile – hatten Einfluss auf die Syntax. Der MIME-Type lautet text/markdown.</p>

### Bild

Bild mit alternativ Text. Der Altertiv Text hat den Sinn, falls das Bild nicht dargestellt werden kann, wird der Text angezeigt.

```
![Text_falls_das_bild_nicht_dargestelltwird](link_zum_bild.jpg)
```

### Überschriften

Mit der # können unterschiedlich starke überschriften definiert werden.

```
# Überschrift 1
## Überschrift 1.1
### überschrift 1.1.1
#### Überschrift 1.1.1.1
# Überschrift 2
```

### Aufzählungen

Mit - kann ein Aufzählungspunkt erstellt werden.

```
- Punkt1
- Punkt2
- Punkt3
```

### Fetter Text
Mit ** vor und nach einer Zeichenkette, kann ein fetter Text erzeugt werden.

```
** Fetter Text **
```

### Kursiver Text
Mit * vor und nach einer Zeichenkette, kann ein Kursiver Text erzeugt werden.

```
* Kursiver Text *
```

### Links

Mit []() können links und Texte welche über dem Link liegen definiert werden. (Text wird statt dem Link angezeigt)

```jsx
[https://link/to/site](Beispieltext statt dem Link)
```

### Code Snipets einfügen

Mit "```C#" kann ein Code Snipt für C# eingefügt werden, dies funktioniert auch mit anderen Sprachen (Java, C++, ...)

```c#
```C#
```

##Referenzen
Noch mehr Infos stehen auf der offiziellen <a href="https://www.markdownguide.org/basic-syntax/#italic">markdownguide.org</a> Webseite</br>
Informationen über die die Markdown Language wurden von <a href="https://de.wikipedia.org/wiki/Markdown">Wikipedia</a> bezogen.
