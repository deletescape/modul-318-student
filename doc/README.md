# �V�

_Till Kottmann, 23.05.2017_

![Screenshot](images/screenshot.png)

## Zweck des Dokuments

Anleitung, Dokumentation und Information zum �V� �K Projekt von Till Kottmann

## Installation

Ein Installer (Installer.msi) f�r die aktuelle Version kann immer auf meiner [GitHub Releases Seite](https://github.com/deletescape/modul-318-student/releases) gefunden werden.
Dieser Installer kann einfach heruntergeladen und ausgef�hrt werden um �V� korrekt auf dem System zu installieren.

### Deinstallation

Das Programm kann �ber "Programme und Funktionen" in der Systemsteuerung wieder vom System entfernt werden.

## Management Summary

Der Zweck dieses Programmes, welches im �K zum Modul 318 entstanden ist, ist Aktuelle �V Verbindungen zwischen zwei Orten, so wie auch alle abfahrten von einer bestimmten Haltestelle anzuzeigen.
Umgesetzt wurde dies mit einem modernen Design und benutzerfreundlichen Hilfestellungen f�r die Stationensuche.
Der Benutzer soll die M�glichkeit haben Stationen mithilfe von Live-Vorschl�gen effizient zu finden und sich dann Verbindungen anzeigen lassen.

## Umsetzung

### Anforderungen

|  ID  | Umgesetzt | Kommentar                                                                                |
|:----:|:---------:|------------------------------------------------------------------------------------------|
| A001 |     Ja    |                                                                                          |
| A002 |     Ja    |                                                                                          |
| A003 |     Ja    |                                                                                          |
| A004 |     Ja    | Eigene Umsetzung mit ListBox f�r Integration im Material Design                          |
| A005 |    Nein   | Aufwand um diese Funktion mit dem Design zu vereinbaren w�re f�r den �K zu gross gewesen |
| A006 |     Ja    | Link zu Google Maps auf Field Label                                                      |
| A007 |    Nein   |                                                                                          |
| A008 |    Nein   |                                                                                          |

### Eigene Features / Umsetzungen

 * Material Design
 * Auto Complete Funktion mit ListBox

## Testf�lle

### Testfall "Station Suchen"

#### Vorbedingung

Das Programm muss gestartet sein und der Verbindungs Tab selektiert sein. Internetverbindung muss vorhanden sein

#### Testszenario

| Schritt |                  Aktivit�t                  |              Erwartetes Resultat             |
|:-------:|:-------------------------------------------:|:--------------------------------------------:|
|    1    | Benutzer gibt "Luz" im Abfahrtsort Feld ein | "Luzern" sollte an zweiter Stelle erscheinen |

### Testfall "Verbindung Suchen"

#### Vorbedingung

Das Programm muss gestartet sein und der Verbindungs Tab selektiert sein. Internetverbindung muss vorhanden sein

#### Testszenario

| Schritt |                     Aktivit�t                    |                          Erwartetes Resultat                         |
|:-------:|:------------------------------------------------:|:--------------------------------------------------------------------:|
|    1    |    Benutzer gibt "Luz" im Abfahrtsort Feld ein   |             "Luzern" sollte an zweiter Stelle erscheinen             |
|    2    | Im Dropdown den Eintrag Luzern Doppelt anklicken |   Das Dropdown schliesst sich und in der Textbox steht nun "Luzern"  |
|    3    |    Benutzer gibt "Z�rich" im Zielort Feld ein    |              Das Dropdown mit den Vorschl�gen erscheint              |
|    4    |     "Z�rich HB" im Dropdown doppelt anklicken    | Das Dropdown schliesst sich und in der Textbox steht nun "Z�rich HB" |
|    5    |              Den Such Button Klicken             |   Es sollten nun ca 5 Resulate erscheinen (Je nach tageszeit, usw)   |

### Testfall "Abfahrtsmonitor"

#### Vorbedingung

Das Programm muss gestartet sein und der Verbindungs Tab selektiert sein. Internetverbindung muss vorhanden sein

#### Testszenario

| Schritt |                     Aktivit�t                    |                                   Erwartetes Resultat                                  |
|:-------:|:------------------------------------------------:|:--------------------------------------------------------------------------------------:|
|    1    |     Benutzer gibt "Luz" im Stations Feld ein     |                      "Luzern" sollte an zweiter Stelle erscheinen                      |
|    2    | Im Dropdown den Eintrag Luzern Doppelt anklicken |            Das Dropdown schliesst sich und in der Textbox steht nun "Luzern"           |
|    3    |              Den Such Button Klicken             | Es sollten nun Resulate erscheinen (Anzahl ist je nach Tageszeit, usw unterschiedlich) |

### Testfall "GMaps"

#### Vorbedingung

Das Programm muss gestartet sein und der Verbindungs Tab selektiert sein. Internetverbindung muss vorhanden sein

#### Testszenario

| Schritt |                     Aktivit�t                    |                              Erwartetes Resultat                              |
|:-------:|:------------------------------------------------:|:-----------------------------------------------------------------------------:|
|    1    |    Benutzer gibt "Luz" im Abfahrtsort Feld ein   |                  "Luzern" sollte an zweiter Stelle erscheinen                 |
|    2    | Im Dropdown den Eintrag Luzern Doppelt anklicken |       Das Dropdown schliesst sich und in der Textbox steht nun "Luzern"       |
|    3    |        Auf das "Abfahrtsort" Label klicken       | Der Standardbrowser �ffnet Google Maps mit einem Pin auf dem Luzerner Bahnhof |

## Material Design

Das �V� Programm ist im sch�nen und vorallem modernen [Material Design](https://material.io) von Google gehalten. Dies ist nur n�glich dank dem grossartigen [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin) von [Ignace Maes](http://ignacemaes.com).

## Use Cases

![Usecase Diagram](images/usecase.png)

## Aktivit�tendiagramme

![Activity Diagrams](images/activitydiagrams.png)

## Anforderungen

|  ID  | Beschreibung                                                                  |
|:----:|-------------------------------------------------------------------------------|
| A001 | Stationen k�nnen gesucht werden                                               |
| A002 | Die n�chsten 4-5 Verbindung zwischen den gew�hlten Stationen werden angezeigt |
| A003 | Alle Verbindungen von einer bestimmten Haltestelle als Abfahrtstafel sichtbar |
| A004 | W�hrend der Eingabe erscheinen bereits Suchvorschl�ge                         |
| A005 | Verbindungen k�nenn zu beliebigen Zeitpunkten gesucht werden                  |
| A006 | Es ist ersichtlich wo sich eine Station befindet                              |
| A007 | Es kann nach Haltestellen in der n�he gesucht werdem                          |
| A008 | Gefundene Resultate k�nnen per Mail weitergeleitet werden                     |

[Coding Guidelines](http://www.dofactory.com/reference/csharp-coding-standards)

