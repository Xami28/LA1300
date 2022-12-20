# Projekt-Dokumentation



Chocolate(Jesenko, Lucena, von Rogall, Marku, Greub)

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|27.11.2022| 0.0.1   |Heute haben wir den ersten Teil unserer Projektdokumentation geschrieben und ein Usecase Diagramm erstellt.|
| 29.11.2022| 0.0.2| Wir haben mit dem Programmieren gestartet. Wir haben den Startbildschirm und eine Spielfigur die wir bewegen können programmiert.|               
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Wir erstellen ein kleines Spiel in dem man über Hindernisse springen muss.

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
| 10   |kann             |Qualität  |Als User möchte ich am Anfang einen Schwierigkeitsgrad aussuchen können, damit ich sofort eine Herausforderung haben kann|
| 11   |kann             |Qualität  |Als User möchte ich am Anfang einen Bildschirm, bei dem ich verschiedene Auswahlmöglichkeiten habe wie Spielen, Optionen, Steuerung und Zurück, damit ich auch noch mehr über das Spiel herausfinden kann und weil ich das schöner finde.
| 12   |kann             |Qualität  |Als User möchte ich das es mehrere Level gibt, weil ich das als User bevorzuge|
| 13   |kann             |Qualität  |Als User möchte ich das ich wenn ich auf "Controls" drücke, dass mir die Steuerung des Spiels angezeigt wird, damit ich weiss welche Knöpfe ich drücken muss um den Spieler zu bewegen.|
| 14   |kann             |Qualität  |Als User möchte ich wenn ich auf "Options" drücke das ich wählen kann wie ich heisse und wie ich das Spielfenster einstellen will.|
| 15   |kann             |Qualität  |Als User möchte ich das wenn ich auf "Exit" drücke, dass sich dann das spiel schliesst damit ich eine schönere option habe das Spiel zu schliessen.|
| 16   |kann             |Qualität  |Als User möchte ich das wenn ich auf "Credits" drücke, dass mir die Credits angezeigt werden damit ich das Team sehen kann das dieses Spiel entwickelt hat.|





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
| 5.2  |   Spiel gestartet, Objekte erschienen    |   Spieler überspringt Objekte         |  Es ersheinen verschiedene Objekte     |
| 6.1  |   Spiel gestartet, Objekte erschienen    |   Spieler berührt ein Objekt    |    Die erreichte Punktzahl wird angezeigt    |
| 6.2  |   Spiel gestartet, Objekte erschienen    |   Spieler springt über Objekte  |   Die Punktzahl erhöht sich  |
| 7.1  |   Spiel gestartet, Objekte erschienen, mehr übersprungene Objekte als der aktuelle Highscore    |   Spieler berührt ein Objekt    |   Neuer Highscore wird angezeigt   |
| 7.2  |   Spiel gestartet, Objekte erschienen, weniger übersprungene Objekte als der aktuelle Highscore    |   Spieler berührt ein Objekt    |   Kein neuer Highscore wird abgespeichert   |
|7.3   |  Spiel gestartet, Objekte erschienen| Spieler berührt Objekt| drei Top Scores werden angezeigt. |
| 8.1 |    Programm gestartet   |   Auf "Play" drücken     |  Eingabe für den Namen öffnet sich |
| 8.2 |    Spiel gestartet, Objekte erschienen    |   Spieler berührt ein Objekt    |    Die erreichte Punktzahl wird neben dem zuvor eingegebenen Namen angezeigt  |
| 8.3 |    Spiel gestartet, Objekte erschienen, mehr übersprungene Objekte als der aktuelle Highscore   |   Spieler berührt ein Objekt    |   Der Highscore wird neben dem Namen der Person eingetragen    |
| 9.1 |    Spiel gestartet, Objekte erschienen    |   Spieler überspringt das 10. Objekt  |  Geschwindigkeit der Objekte wird erhöht      |
| 9.2 |    Spiel gestartet, Objekte erschienen    |   Spieler überspringt das 20. Objekt  |  Geschwindigkeit der Objekte wird erneut erhöht    |
|10.1 |   Programm gestartet, Auf "Play" gedrückt  |  Name wird eingegeben  | Fenster öffnet sich, indem zwischen den verschiedenen Schwierigkeitsgraden ausgesucht werden kann. |
|11.1 |Programm wurde gestartet |" "| Fenster mit verschiedenen Optionen wird angezeigt.|
|12.1 |Im Startfenster wurde auf "Play" gedrückt|" "| Fenster mit der Level auswahl wird angezeigt.|
|13.1 |Startfenster wurde geöfnet|Auf "Controls" gedrückt| Fenster mit der Steuerung des Spiels wird angezeigt.|
|14.1 |Startfenster wurde geöfnet|Auf "Options" gedrückt| Fenster mit Namenseingabe und Spielfenster einstellung wird angezeigt.|
|15.1 |Startfenster wurde geöfnet|Auf "Exit" gedrückt| Spiel wird beendet.|
|16.1 |Startfenster wurde geöfnet|Auf "Credits" gedrückt| Fenster mit den Entwicklern wird angezeigt.|



### 1.4 Diagramme

![T-Rex Game Use Case Diagramm](https://user-images.githubusercontent.com/110893302/204498597-b36ae964-814b-4370-ae12-2c1ff8242d69.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |29.11.2022|Erik|1. Userstory|30 min|
| 2.A  |29.11.2022|Marek|2. Userstory|60min|
| 3.A  |29.11.2022|Stefan|3. Userstory|60min|
|11.A  |29.11.2022|Marek|11. Userstory|20min|
| 4.A  |06.12.2022|Samuel|4. Userstory|30min|
| 5.A  |06.12.2022|Erik|5. Userstory|60min|
| 6.A  |06.12.2022|Marek|6.Userstory| 30min|
|12.A  |06.12.2022|Marek|12.Userstory|90min|
| 7.A  |13.12.2022|Manuel|7. Userstory|60min|
| 8.A  |13.12.2022|Stefan|8. Userstory|60min|
| 9.A  |13.12.2022|Samuel|9. Userstory|60min|
|10.A  |13.12.2022|Manuel|10. Userstory|60min|
|13.A  |13.12.2022|Marek|13. Userstory|60min|
|14.A  |13.12.2022|Marek|14. Userstory|30min|
|15.A  |13.12.2022|Marek|15. Userstory|20min|
|16.A  |13.12.2022|Marek|16. Userstory|10min|


Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

Wir haben uns dazu entschieden das man in unserem spiel durch ein Labürint hindurch springen muss, deswegen passen nicht mehr alle userstorys zu unserem Programm.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 29.11 | Marek, Samuel| 30min      | 30min             |
| 2.A  | 29.11 | Erik, Stefan, Manuel      | 60min|90min       |
|11.A  | 29.11 | Marek, Samuel| 20min      | 25min             |
| 3.A  | 06.12 | Stefan, Marek | 60min     | 70min             |
| 4.A  | 06.12 | Marek         | 30min     | 60min             |
| 9.A  | 06.12 | Marek         | 60min     | 90min             |
|12.A  | 06.12 | Marek         | 90min     | 60min             |
|14.A  | 13.12 | Marek         | 60min     | 20min             |
|15.A  | 13.12 | Marek         | 20min     | 20min             |





## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |20.12.2022| OK|Stefan Jesenko|
| 1.2  |20.12.2022| OK|Stefan Jesenko|
| 2.1  |20.12.2022| OK|Stefan Jesenko|
| 3.1  |20.12.2022| OK|Stefan Jesenko|
| 3.2  |20.12.2022|NOK|Stefan Jesenko|
| 3.3  |20.12.2022|NOK|Stefan Jesenko|
| 4.1  |20.12.2022|NOK|Stefan Jesenko|
| 4.2  |20.12.2022|NOK|Stefan Jesenko|
| 5.1  |20.12.2022|NOK|Stefan Jesenko|
| 5.2  |20.12.2022|NOK|Stefan Jesenko|
| 6.1  |20.12.2022|NOK|Stefan Jesenko|
| 6.2  |20.12.2022|NOK|Stefan Jesenko|
| 7.1  |20.12.2022|NOK|Stefan Jesenko|
| 7.2  |20.12.2022|NOK|Stefan Jesenko|
| 7.3  |20.12.2022|NOK|Stefan Jesenko|
| 8.1  |20.12.2022|NOK|Stefan Jesenko|
| 8.2  |20.12.2022|NOK|Stefan Jesenko|
| 8.3  |20.12.2022|NOK|Stefan Jesenko|
| 9.1  |20.12.2022|NOK|Stefan Jesenko|
| 9.2  |20.12.2022|NOK|Stefan Jesenko|
|10.1  |20.12.2022|NOK|Stefan Jesenko|
|11.1  |20.12.2022| OK|Stefan Jesenko|
|12.1  |20.12.2022| OK|Stefan Jesenko|
|13.1  |20.12.2022|NOK|Stefan Jesenko|
|14.1  |20.12.2022| OK|Stefan Jesenko|
|15.1  |20.12.2022| OK|Stefan Jesenko|
|16.1  |20.12.2022|NOK|Stefan Jesenko|

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.

