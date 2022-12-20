# Lernbericht

Chocolate (Jesenko, Marku, Greub, von Rogall, Losada)
## Einleitung

Wir haben im Lernatelier den Auftrag bekommen, ein Programm mit Windows Forms zu schreiben.
## Was haben wir gelernt?
Wir haben gelernt, wie wir `key inputs` in Windows Forms benutzen um unsere Spielfigur bewegen zu können.
## Beschreibung
Wir haben in unserem Programm die Funktion `keydown` und `keyup` benutzt.
Die Funktion `keydown` prüft ob eine Taste auf der Tastatur heruntergedrückt wird. Die Funktion `keyup` überprüft ob eine Taste gerade nicht heruntergedrückt wird. Wir haben das in unserem Programm so eingebaut, dass wir bool's für alle Tasteninputs haben, die wenn sie dann `true` sind die Spielfigur bewegen.
```C#
private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { if (onground == true) { jump = true; }}
            if (e.KeyCode == Keys.A) { left = true; }
            if (e.KeyCode == Keys.D) { right = true; }
        }
```
