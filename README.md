Number Guessing Game

Ein kleines Unity-Spiel, bei dem der Spieler eine Zahl durch binäre Suche erraten muss.

Ziel des Spiels

Das Spiel denkt sich eine Zahl aus.
Der Spieler versucht, die richtige Zahl zu finden, indem er Hinweise verwendet.

Steuerung / Buttons
Higher
Die gesuchte Zahl ist höher als die aktuell angezeigte Zahl.
Lower
Die gesuchte Zahl ist niedriger als die aktuell angezeigte Zahl.
Correct
Die aktuell angezeigte Zahl ist richtig.
Restart
Startet das Spiel neu und setzt alle Werte zurück.
Binäre Suche

Das Spiel verwendet das Prinzip der binären Suche:
Nach jedem Hinweis wird der mögliche Zahlenbereich halbiert.
Dadurch kann die richtige Zahl sehr schnell gefunden werden.

Beispiel:

Bereich: 1–100
Mitte = 50
Wenn die Zahl höher ist → neuer Bereich: 51–100
Wenn die Zahl niedriger ist → neuer Bereich: 1–49
Unity-Version

Dieses Projekt wurde mit Unity 6000.0.57f1 erstellt.

Startszene

Die Startszene des Projekts ist:

MainScene
