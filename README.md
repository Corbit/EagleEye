# EagleEye

2D Top-Down Puzzle Shooter für den PC

## Zusammenfassung

Du bist ein Jäger im Wald, doch musst du dich für eine erfolgreiche Jagd auf die Hilfe deiner Greifvögel verlassen. Sie alle haben verschiedenen Stärken. Es kann entweder nur die Spielerposition, die Umgebung oder das verschiedene Wild im Wald erfasst werden. Aber pass auf nicht das falsche Tier zu erlegen. Und behalte deine Munition/Pfeile im Blick.

## Anforderungen

- [x] Mit Num Pad/Zahlen durch die verschiedenen Ansichten filtern.
  - [x] Ansicht für die Position des Players
  - [x] Ansicht für die jeweiligen geschützten Targets
  - [x] Ansicht für die freigegeben Targets
  - [x] Ansicht der Karte inklusiven Hindernissen
- [x] Zielen und Schießen via Maus
  - [x] Position des Mauszeigers in Relation zum Player definiert die Richtung in die geschossen wird
  - [x] Durch Klicken der linken Maustaste wird ein Projektil verschossen
- [x] Player verschießt Projektile/Pfeile, die von Hindernissen abprallen
  - [x] Einfallwinkel = Ausfallwinkel
- [o] Hörbares Signal, wenn ein Target erlegt wurde
  - [x] Auch wenn gerade nicht die Ansicht des Targets aktiv ist
- [x] Das Level ist gescheitert, wenn der Player ein geschütztes Target erlegt oder keine Munition mehr hat.
  - [x] Auswahlmenu
    - [x] Level neu starten
    - [x] Zurück zum Startmenü
- [ ] 9 verschiedene Level
  - [ ] inklusive 3 Tutorial Level
    - [x] Spieler lernt auf Targets zu schießen
    - [x] Spieler lernt nicht auf falsche Targets zu schießen
    - [ ] Spieler lernt, dass Projektile von Hindernissen abprallen
- [ ] In höheren Leveln (~ ab Level 6) erhöht sich der Schwierigkeitsgrad.
  - [x] Anstatt stillstehenden Targets, gibt es nur Targets, die sich auf einer vordefinierten Route bewegen
  - [x] Das gilt für geforderte Targets und zu verschonende Targets
  - [ ] In nachfolgenden Leveln beweget sich auch der Player auf vordefinierten Routen, um die Schwierigkeit zu erhöhen.
  - [ ] Der Spieler muss so den Abschuss auch zeitlich planen
- [] Overlay/ seitliche Anzeige für Informationen
  - [x] Levelstufe
  - [x] Munitionsstand
  - [ ] Momentane Ansicht, mögliche Ansichten
  - [x] geschützte Targets
  - [x] freigegebenes Target
- [ ] Bestenliste für die schnellste Zeit
  - [x] Pro Level
  - [ ] für den gesamten Durchlauf
- [] Startmenü
  - [x] Starten eines neuen Spieles
  - [x] Beenden der Anwendung
  - [x] Levelauswahl
  - [ ]Bestenliste
- [x] Pausemenü
  - [x] Weiterspielen
  - [x] Level beenden/Startmenü
