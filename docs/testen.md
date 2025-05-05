---
layout: default
title: Testen
nav_order: 5
---

# Testen

Effectief testen in Unity combineert technische validatie via het Test Framework met gebruikerstesten waarbij mensen in realistische scenario's uw AR-applicatie beoordelen. Deze tweeledige aanpak waarborgt zowel technische stabiliteit als gebruiksvriendelijke interactie. Hieronder wordt uitgelegd hoe beide testmethoden geïmplementeerd kunnen worden.

## Inhoud
- [Vereisten](#vereisten)
- [Unit Testing in Unity](#unit-testing-in-unity)
  - [Stap 1: Test Framework Installeren](#stap-1-test-framework-installeren)
  - [Stap 2: Een test assembly aanmaken](#stap-2-een-test-assembly-aanmaken)
  - [Stap 3: Een unit test script schrijven](#stap-3-een-unit-test-script-schrijven)
  - [Stap 4: Testen uitvoeren](#stap-4-testen-uitvoeren)
  - [Stap 5: Testen analyseren](#stap-5-testen-analyseren)
- [Gebruikerstesten](#gebruikerstesten)
  - [Uitvoering](#uitvoering)

## Vereisten

- **Unity Hub**: Moet al geïnstalleerd zijn.
- **Unity Editor**: Moet al geïnstalleerd zijn met de geschikte versie (Unity 2022.3.60f LTS)
- **Unity Project**: Een geconfigureerd bestaand Unity-project
- **IDE**: Een IDE naar keuze (in dit document is dat Visual Studio Community 2022)

## Unit Testing in Unity

Unit testing in Unity vormt een essentieel onderdeel bij de ontwikkeling van robuuste en betrouwbare applicaties. Deze stapsgewijze handleiding beschrijft hoe u unit tests kunt opzetten en uitvoeren in Unity. De instructies zijn primair gericht op nieuwe projecten, maar houd er rekening mee dat bij bestaande projecten sommige stappen mogelijk al gedeeltelijk of volledig zijn uitgevoerd.

### Stap 1: Test Framework Installeren

1. Open de Unity Package Manager via **Window > Package Manager**
2. Selecteer **Unity Registry** in de dropdown
3. Zoek naar **Test Framework** en klik op **Install**
4. Wacht tot de installatie is voltooid

### Stap 2: Een test assembly aanmaken

1. Creëer een nieuwe map in uw Assets folder met de naam **Tests**
2. Maak twee submappen: **EditMode** en **PlayMode**
3. Rechtsklik op de EditMode map en selecteer **Create > Testing > Tests Assembly Folder**
4. Herhaal dit voor de PlayMode map

### Stap 3: Een unit test script schrijven

1. Rechtsklik op de EditMode map en selecteer **Create > C# Script**
2. Noem het script bijvoorbeeld "ExampleTest"
3. Open het script en vervang de inhoud met uw eigen test

> **Note**: In dit voorbeeld wordt de EditMode map genoemd, maar bedenk goed wat voor soort functionaliteit er getest moet worden.
Voor meer uitleg zie de ***Unity Guidelines***

### Stap 4: Testen uitvoeren

1. Open de Test Runner via **Window > General > Test Runner**
2. Selecteer het "EditMode" tabblad voor EditMode testen of "PlayMode" voor PlayMode testen
3. Klik op **Run All** om alle testen uit te voeren, of selecteer een specifieke test om uit te voeren

### Stap 5: Testen analyseren

1. Bekijk de resultaten in het Test Runner venster
2. Groene testen zijn geslaagd, rode testen zijn gefaald
3. Klik op een gefaalde test om details te zien over waarom de test is mislukt

## Gebruikerstesten

Gebruikerstesten bieden essentiële inzichten in hoe eindgebruikers daadwerkelijk met producten interacteren, waardoor ontwikkelteams functionaliteiten kunnen optimaliseren op basis van directe gebruikerservaringen.

Voor deze testen is een document opgesteld met diverse testscenario's. Bij elk scenario is specifieke testdata gedefinieerd die de testpersoon kan gebruiken tijdens de uitvoering van de testen.

### Uitvoering
De testpersonen doorlopen individueel vooraf opgestelde scenario's, die als stappenplan fungeren voor het gebruik van de functionaliteit zoals een eindgebruiker deze zou ervaren.

Bij elk testscenario worden systematisch vastgelegd:

 - Testlocatie
 - Datum en exacte tijdstip
 - Benodigde tijd voor uitvoering
 - Observaties tijdens het testen
 - Feedback van de testpersoon
 - Verificatie van succesvolle doorloop van het scenario

Na afronding van alle testen worden de verzamelde observaties en feedback geanalyseerd. Op basis van deze analyse worden gerichte aanpassingen aan de functionaliteit doorgevoerd om de gebruikerservaring te optimaliseren.