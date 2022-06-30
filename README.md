# EagleEye
 ### 2D Top-Down Puzzle Shooter für den PC
## Zusammenfassung

Du bist ein Jäger im Wald, doch musst du dich für eine erfolgreiche Jagd auf die Hilfe deiner Greifvögel verlassen. Sie alle haben verschiedenen Stärken. Es kann entweder nur die Spielerposition, die Umgebung oder das verschiedene Wild im Wald erfasst werden. Aber pass auf nicht das falsche Tier zu erlegen. Und behalte deine Munition/Pfeile im Blick.

## Anforderungen

- [ ] Mit Num Pad/Zahlen durch die verschiedenen Ansichten filtern.
    - [x] Ansicht für die Position des Players
    - [ ] Ansicht für die jeweiligen geschützten Targets
    - [ ] Ansicht für die freigegeben Targets
    - [x] Ansicht der Karte inklusiven Hindernissen
- [x] Zielen und Schießen via Maus
    - [x] Position des Mauszeigers in Relation zum Player definiert die Richtung in die geschossen wird
    - [x] Durch Klicken der linken Maustaste wird ein Projektil verschossen 
- [ ] Player verschießt Projektile/Pfeile, die von Hindernissen abprallen
    - [ ] Einfallwinkel = Ausfallwinkel
- [ ] Hörbares Signal, wenn ein Target erlegt wurde
    - [ ] Auch wenn gerade nicht die Ansicht des Targets aktiv ist
- [ ] Das Level ist gescheitert, wenn der Player ein geschütztes Target erlegt oder keine Munition mehr hat.
    - [x] Auswahlmenu
        - [ ] Level neu starten
        - [ ] Zurück zum Startmenü
- [ ] 9 verschiedene Level
    - [ ] inklusive 3 Tutorial Level
        - [ ] Spieler lernt auf Targets zu schießen
        - [ ] Spieler lernt nicht auf falsche Targets zu schießen
        - [ ] Spieler lernt, dass Projektile von Hindernissen abprallen
- [ ] In höheren Leveln (~ ab Level 6) erhöht sich der Schwierigkeitsgrad.
    - [ ] Anstatt stillstehenden Targets, gibt es nur Targets, die sich auf einer vordefinierten Route bewegen
    - [ ] Das gilt für geforderte Targets und zu verschonende Targets
    - [ ] In nachfolgenden Leveln beweget sich auch der Player auf vordefinierten Routen, um die Schwierigkeit zu erhöhen.
    - [ ] Der Spieler muss so den Abschuss auch zeitlich planen
- [ ] Overlay/ seitliche Anzeige für Informationen
    - [ ] Levelstufe
    - [ ] Munitionsstand
    - [ ] Momentane Ansicht, mögliche Ansichten
    - [ ] geschützte Targets
    - [ ] freigegebenes Target
- [ ] Bestenliste für die schnellste Zeit
    - [ ] Pro Level
    - [ ]für den gesamten Durchlauf
- [ ] Startmenü
    - [ ] Starten eines neuen Spieles
    - [ ] Beenden der Anwendung
    - [ ] Levelauswahl
    - [ ]Bestenliste
- [x] Pausemenü
    - [x] Weiterspielen
    - [x] Level beenden/Startmenü
