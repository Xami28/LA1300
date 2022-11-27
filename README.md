# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

✍️ Ihr Gruppenname und Ihre Nachnamen

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

✍️ Beschreiben Sie Ihr Projekt in einem griffigen Satz.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |muss             |Funktional|Als User möchte ich das Spiel starten können, damit ich das Spiel spielen kann.|
| 2    |muss             |Funktional|Als User möchte ich Springen können, damit ich über Hindernisse Springen kann.|
| 3    |muss             |Funktional|Als User möchte ich, dass es Objekte gibt, über die ich Springen kann, damit das Spiel interessanter ist.|
| 4    |muss             |Funktional|Als User möchte ich das Spiel neu startet, wenn ich ein Objekt berühre, damit es schwieriger wird.|
| 5    |muss             |Funktional|Als User möchte ich, dass immer neue Objekte auf mich zukommen, damit das Spiel spannend ist.|
| 6    |muss             |Funktional|Als User möchte ich, dass ich sehen kann, wie weit ich gekommen bin, damit ich weiss wie gut ich war.|
| 7    |kann             |Qualität  |Als User möchte ich das ich sehen kann, was meine besten Versuche waren.|
| 8    |kann             |Qualität  |Als User möchte ich, dass ich am Anfang meinen Namen eingeben kann, damit ich zwischen versuchen von verschiedenen Personen unterscheiden kann|
| 9    |kann             |Qualität  |Als User möchte ich das Spiel schwerer wird desto weiter ich komme.|
| 10   |kann             |Qualirät |Als User möchte ich am Anfang einen Schwierigkeitsgrad aussuchen können, damit ich sofort eine Herausforderung haben kann|

✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |   Programm gestartet  |    Auf "Play" drücken     |  Spiel beginnt       |
| 1.2  |   Programm gestartet  |    Auf "Play" drücken     |  Spieler erscheint   |
| 2.1  |   Spiel gestartet     |    Auf "Jump" drücken     |  Charakter springt   |
| 3.1  |   Spiel gestartet     |    Auf "Play" drücken     |  Objekte erscheinen  |
| 3.2  |   Spiel gestartet     |    Auf "Play" drücken     |  Die Objekte bewegen sich von links nach rechts      |
| 3.3  |   Speil gestartet     |    Auf "Play" drücken     |  Für jedes übersprungene Objekt erhöht sich der Score um 1 |
| 4.1  |   Spiel gestartet, Objekte erschienen    |   Spieler berührt ein Objekt    |    Score wird zurückgesetzt       |
| 4.2  |   Spiel gestartet, Objekte erschienen    |   Spieler berührt ein Objekt    |    "Game Over" Screen erscheint   |
| 5.1  |   Spiel gestartet, Objekte erschienen    |   Spieler überspringt das 5. Objekt   |  Es erscheinen nun immer mehr Objekte  |
| 6.1  |   Spiel gestartet, Objekte erschienen    |   Spieler berührt ein Objekt    |    Die erreichte Punktzahl wird angezeigt    |
| 7.1  |   Spiel gestartet, Objekte erschienen, mehr übersprungene Objekte als der aktuelle Highscore    |   Spieler berührt ein Objekt    |   Neuer Highscore wird angezeigt   |
| 7.2  |   Spiel gestartet, Objekte erschienen, weniger übersprungene Objekte als der aktuelle Highscore    |   Spieler berührt ein Objekt    |   Kein neuer Highscore wird abgespeichert   |
| 8.1 |    Programm gestartet   |   Auf "Play" drücken     |  Eingabe für den Namen öffnet sich |
| 8.2 |    Spiel gestartet, Objekte erschienen    |   Spieler berührt ein Objekt    |    Die erreichte Punktzahl wird neben dem zuvor eingegebenen Namen angezeigt  |
| 8.3 |    Spiel gestartet, Objekte erschienen, mehr übersprungene Objekte als der aktuelle Highscore   |   Spieler berührt ein Objekt    |   Der Highscore wird neben dem Namen der Person eingetragen    |
| 9.1 |    Spiel gestartet, Objekte erschienen    |   Spieler überspringt das 10. Objekt  |  Geschwindigkeit der Objekte wird erhöht      |
| 9.2 |    Spiel gestartet, Objekte erschienen    |   Spieler überspringt das 20. Objekt  |  Geschwindigkeit der Objekte wird erneut erhöht    |
| 10.1 |   Programm gestartet, Auf "Play" gedrückt  |  Name wird eingegeben  | Fenster öffnet sich, indem zwischen den verschiedenen Schwierigkeitsgraden ausgesucht werden kann. |


✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.

