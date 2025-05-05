---
layout: default
title: Unity Guidelines
nav_order: 4
---

# Unity Guidelines

Deze gids helpt u bij het correct gebruik van een projectstructuur in Unity, volgens de Unity naming conventions.

## Inhoud
- [Unity Structuur](#unity-structuur)
  - [Audio](#audio)
  - [Materials](#materials)
  - [MetaXR](#metaxr)
  - [Oculus](#oculus)
  - [Plugins](#plugins)
  - [Prefabs](#prefabs)
  - [Resources](#resources)
  - [Scenes](#scenes)
  - [Scripts](#scripts)
  - [Settings](#settings)
  - [Shaders](#shaders)
  - [Streaming Assets](#streaming-assets)   
  - [Tests](#tests)
  - [Textures](#textures)
  - [XR](#xr)
- [Unity Naming Conventions](#unity-naming-conventions)
  - [Algemene Principes](#algemene-principes)
  - [Naming Conventions in Scripts](#naming-conventions-in-scripts)
  - [Unity-specifieke Naming Conventions](#unity-specifieke-naming-conventions)


## Unity Structuur

Een goed georganiseerde Unity-projectstructuur is essentieel voor efficiënte ontwikkeling, samenwerking en onderhoud.
Unity biedt flexibiliteit in hoe het project wordt georganiseerd, maar een doordachte structuur die aansluit bij standaarden levert aanzienlijke voordelen op. Het vermindert technische schuld, versnelt ontwikkelingstijd, vergemakkelijkt onboarding van nieuwe teamleden en voorkomt veelvoorkomende problemen zoals dubbele assets of conflicterende scripts.

Hieronder volgt een overzicht van de mappen in een goed gestructureerd Unity Project en hoe deze bijdragen aan een gestroomlijnde ontwikkelingsworkflow. De mappen bevinden zich in de Assets map van het project.

### Audio

De Audio map bevat alle geluidsbestanden, waaronder muziek, geluidseffecten en spraakopnames. Deze bestanden vormen de auditieve laag van uw applicatie en kunnen worden afgespeeld tijdens specifieke gebeurtenissen of als achtergrondmuziek. De map kan verder worden onderverdeeld in submappen zoals Muziek, SFX en Spraak voor een betere organisatie.

### Materials

De Materials map bevat alle materialen die de visuele eigenschappen van objecten in uw project definiëren. Materialen bepalen hoe oppervlakken reageren op licht, welke texturen ze weergeven, en andere visuele eigenschappen.
Door materialen zorgvuldig te organiseren, wordt het gemakkelijker om een consistente visuele stijl te handhaven en om materialen te vinden wanneer u objecten aanpast of nieuwe assets maakt.

### MetaXR

De MetaXR map bevat componenten van de nieuwere Meta XR SDK, ontworpen voor ontwikkeling op Meta Quest-headsets. Deze map bevat scripts, prefabs en andere assets die specifiek zijn voor Meta's XR-platform.

### Oculus

De Oculus map bevat componenten van de oudere Oculus Integration SDK. Hoewel Meta deze geleidelijk vervangt door de nieuwere Meta XR SDK, 
blijft deze map behouden in projecten voor achterwaartse compatibiliteit en bij gebruik van componenten die niet beschikbaar zijn in de MetaXR SDK.

### Plugins

De Plugins map bevat native plugins en third-party bibliotheken die Unity's functionaliteit uitbreiden. Hierin staan
platform-specifieke plugins of bestanden, zoals het Android manifest. Aangezien het OS van de Meta Quest 3 Android-based is, is het manifest van belang bij het vragen van permissies aan gebruikers en het verlenen van toegang tot hardware-functionaliteiten zodat de applicaties deze kunnen gebruiken.

### Prefabs

De Prefabs map bevat herbruikbare gameobject-templates die in meerdere scènes kunnen worden gebruikt. Prefabs zijn een van Unity's krachtigste features, omdat ze u in staat stellen om complexe objecten te creëren, configureren en vervolgens in meerdere contexten te hergebruiken. De prefabs kunnen worden onderverdeeld in mappen voor scène-objecten, UI, etc.

### Resources

De Resources map heeft een speciale functie in Unity: assets in deze map kunnen tijdens runtime dynamisch worden geladen via de Resources.Load() functie. Dit is nuttig voor content die niet bij het opstarten geladen hoeft te worden of die dynamisch wordt gewijzigd. Dit kunnen lokalisatiebestanden zijn, maar ook configuraties, dynamisch te laden prefabs, audio en visuele elementen.

> **Note**: Het is belangrijk om te weten dat alle inhoud van de Resources map in het geheugen wordt geladen.

### Scenes

De Scenes map bevat alle .unity scènebestanden die samen uw Meta Quest 3-applicatie vormen. Elke scène vertegenwoordigt een afzonderlijk deel van uw applicatie, zoals een specifieke interface, omgeving of functionaliteit.

Scenes zijn de containers waarin u interactieve elementen plaatst en hun onderlinge relaties definieert. Een goed georganiseerde Scenes map voor een Meta Quest 3-applicatie kan onderverdeeld zijn in categorieën zoals:

- **Hoofdomgevingen**: Primaire gebruiksomgevingen van de applicatie
- **UI**: Menu- en interfacescènes voor navigatie en instellingen
- **Management**: Scènes die persistente applicatiemanagers bevatten

Door scènes logisch te organiseren, wordt het gemakkelijker om de juiste omgeving te laden tijdens ontwikkeling en testing, en om de workflow van uw applicatie te begrijpen.

### Scripts

De Scripts map bevat alle C# code die de functionaliteit van uw applicatie definieert. Hier vindt u onder andere scripts die gebruikersinteracties afhandelen, interfaces besturen en systeemprocessen beheren.

Voor een goede organisatie kunt u deze map onderverdelen in categorieën zoals:

- **Core**: Fundamentele functionaliteit van de applicatie
- **Interaction**: Alles gerelateerd aan gebruikersinteractie
- **UI**: Interface-besturing en weergave
- **Data**: Gegevensverwerking en -beheer
- **Utilities**: Herbruikbare hulpmiddelen en extensies

Deze structuur maakt het eenvoudiger om code terug te vinden, bevordert modulair ontwerp en vergemakkelijkt samenwerking tussen ontwikkelaars.

### Settings

De Settings map bevat project-specifieke instellingen en configuratiebestanden. Het centraliseren van deze bestanden maakt het gemakkelijker om projectinstellingen te beheren en aan te passen.

### Shaders

De Shaders map bevat aangepaste shader-bestanden die bepalen hoe materialen visueel worden weergegeven. Shaders zijn essentieel voor het creëren van speciale visuele effecten en het controleren van hoe licht interacteert met oppervlakken in uw applicatie. Deze map kan worden onderverdeeld in categorieën zoals Standaard, Transparant of Speciale Effecten, afhankelijk van het type shader.

### Streaming Assets

De Streaming Assets map is uniek omdat bestanden in deze map ongewijzigd naar het doelplatform worden gekopieerd. Dit maakt deze map ideaal voor:

- Grote mediabestanden zoals video's die niet door Unity gecomprimeerd moeten worden
- Databases of configuratiebestanden die door externe tools worden gelezen
- Bestanden die via een bestandspad direct toegankelijk moeten zijn

In tegenstelling tot de Resources map, worden bestanden in Streaming Assets niet in het geheugen geladen tenzij u ze expliciet opent, wat deze map geschikt maakt voor grotere bestanden.

### Tests

De Tests map bevat testen die de functionaliteit van uw applicatie valideren. Unity ondersteunt twee hoofdtypen, die elk hun eigen submappen verdienen:

**EditMode Tests**: Deze testen worden uitgevoerd in de Unity Editor zonder dat de applicatie in Play mode hoeft te draaien. Ze zijn ideaal voor:

- Het testen van individuele algoritmes en logica
- Het valideren van data-transformaties
- Het controleren van editor-tools en custom inspectors
- Snelle testen die geen runtime-initialisatie vereisen

EditMode testen zijn doorgaans sneller uit te voeren en isoleren specifieke functionaliteit zonder afhankelijkheid van de complete applicatie-levenscyclus.

**PlayMode Tests**: Deze testen draaien terwijl de applicatie in Play mode is, waardoor ze de daadwerkelijke runtime-omgeving simuleren. Ze zijn perfect voor:

- Het testen van interacties tussen gameobjects
- Het valideren van scene-overgangen
- Het controleren van gebruikersinvoer en -interactie
- Het testen van tijdgebaseerde functionaliteit
- End-to-end tests die de volledige applicatieflow valideren

PlayMode tests zijn krachtiger maar langzamer, en bieden een betere garantie dat functionaliteit werkt zoals verwacht in de uiteindelijke applicatie.

Daarnaast bevat de testmap ook het volgende:
- Test fixtures en hulpmiddelen
- Mock-objecten
- Testdata

### Textures

De Textures map bevat alle afbeeldingsbestanden die worden gebruikt voor 3D-objecten, UI-elementen en omgevingen. Texturen geven detail en visuele rijkdom aan uw applicatie. Voor een goede organisatie kunnen texturen worden onderverdeeld in categorieën zoals Omgeving, Karakters, UI en Materialen, zodat ze gemakkelijk terug te vinden zijn tijdens de ontwikkeling.

### XR

De XR map bevat platform-agnostische XR-componenten, vaak gebruikt in projecten die OpenXR of meerdere VR/AR-platforms ondersteunen. Deze map bevat gemeenschappelijke XR-functionaliteit die niet specifiek is voor één platform.


## Unity Naming Conventions

Consistente naamgeving is essentieel voor leesbare, onderhoudbare code en assets in Unity-projecten. Een duidelijk benoemingsschema vergemakkelijkt samenwerking, versnelt ontwikkeling en vermindert fouten. Hier volgen de belangrijkste richtlijnen voor naamgeving in Unity-projecten:

### Algemene Principes

- Wees descriptief: Namen moeten duidelijk aangeven wat een object of script doet zonder commentaar nodig te hebben.
- Consistentie: Volg dezelfde conventies door het hele project.
- Vermijd afkortingen: Gebruik volledige woorden tenzij afkortingen algemeen bekend zijn (UI, XR, etc.).
- Vermijd generieke namen: Termen als "Manager" of "Controller" zijn nuttig, maar moeten altijd voorafgegaan worden door wat ze beheren (bijv. "PlayerController").


### Naming Conventions in Scripts

Bij het schrijven van C# scripts voor Unity-projecten is het volgen van consistente naamgevingsconventies essentieel voor leesbare en onderhoudbare code. Unity volgt grotendeels de standaard C# naamgevingsconventies met enkele platform-specifieke aanpassingen.

Voor classes en interfaces gebruiken we PascalCase, waarbij elk woord met een hoofdletter begint. Classes worden meestal benoemd als zelfstandige naamwoorden die hun functie beschrijven, zoals PlayerController of InventorySystem. Interfaces beginnen conventioneel met de letter "I", gevolgd door een beschrijvende term die de functionaliteit aangeeft, bijvoorbeeld IInteractable of IDamageable.

Bij variabelen hanteren we camelCase, waarbij het eerste woord met een kleine letter begint en daaropvolgende woorden met een hoofdletter. Private variabelen worden vaak onderscheiden met een underscore prefix (_) of het m_ prefix, zoals in _movementSpeed of m_playerHealth. Publieke variabelen volgen dezelfde camelCase conventie maar zonder prefix: healthPoints of movementSpeed.

Voor methoden gebruiken we PascalCase en kiezen we namen die de actie beschrijven die de methode uitvoert. Effectieve methode-namen beginnen vaak met een werkwoord dat de handeling aangeeft, zoals CalculateDamage() of GetTargetPosition(). Dit maakt de functie van de methode onmiddellijk duidelijk voor andere ontwikkelaars.

Properties in C# volgen de PascalCase conventie en worden meestal benoemd als zelfstandige naamwoorden of bijvoeglijke naamwoorden die de waarde beschrijven die ze vertegenwoordigen. Voorbeelden hiervan zijn Speed of IsActive. Properties die een boolean waarde vertegenwoordigen beginnen vaak met "Is", "Has", of "Can" om hun aard als vraag aan te geven.

Voor constanten gebruiken we ALL_CAPS met underscores tussen woorden, wat ze visueel onderscheidt van variabelen en duidelijk maakt dat hun waarden niet veranderen. Voorbeelden zijn MAX_SPEED of DEFAULT_NAME. Deze naamgevingsconventie helpt ontwikkelaars snel constante waarden in de code te identificeren.

Tenslotte worden events in PascalCase geschreven en vaak benoemd met een werkwoord in de verleden tijd of tegenwoordige tijd gevolgd door een zelfstandig naamwoord, zoals PlayerDied of ScoreChanged. Deze naamgeving maakt duidelijk welke gebeurtenis het event vertegenwoordigt en wanneer het wordt geactiveerd.

Het consequent volgen van deze conventies zorgt voor code die gemakkelijker te lezen, te begrijpen en te onderhouden is, wat essentieel is voor succesvolle teamprojecten en langdurige ontwikkeling.

### Unity-specifieke Naming Conventions

De naamgeving van assets in Unity is een belangrijk aspect van projectorganisatie dat vaak over het hoofd wordt gezien. Een goed systeem maakt navigatie eenvoudiger en versterkt de samenwerking binnen teams.

Voor GameObjects in Unity gebruiken we PascalCase met functionele namen die direct duidelijk maken wat het object doet of vertegenwoordigt. Namen als "Player", "EnemySpawner" of "MainCamera" maken de hiërarchie direct begrijpelijk. In grotere projecten kunnen categorie-prefixes zoals "UI_" of "ENV_" helpen om gerelateerde objecten visueel te groeperen.

Prefabs volgen dezelfde PascalCase-conventie, vaak aangevuld met een categorie-aanduiding of suffix. Dit helpt om snel te identificeren dat het om een herbruikbaar sjabloon gaat, zoals "PlayerPrefab" of "UI_ButtonPrefab". Voor visuele elementen met varianten is een numerieke aanduiding nuttig, bijvoorbeeld "Tree_01" en "Tree_02".

Scenes worden benoemd in PascalCase met namen die de inhoud of functie beschrijven, zoals "MainMenu" of "Level_01_Tutorial". Het toevoegen van een numerieke volgorde maakt de progressie tussen gerelateerde scènes direct zichtbaar en helpt bij het organiseren van de spelervaring.

Voor materialen en textures gebruiken we PascalCase met een type-prefix dat aangeeft om welk soort asset het gaat, bijvoorbeeld "MAT_BrickWall" of "TEX_GrassGround". Deze aanpak maakt het eenvoudig om visuele assets te sorteren en te beheren, vooral in projecten met veel grafische elementen.

Animaties krijgen PascalCase-namen die de beweging of actie beschrijven, zoals "PlayerIdle", "EnemyAttack" of "DoorOpen". Deze intuïtieve naamgeving maakt het werken met animatiecontrollers overzichtelijker.

Layers en Tags, die essentieel zijn voor collision management en object-identificatie, krijgen korte, beschrijvende PascalCase-namen zoals "Player", "Enemy" of "Ground". De eenvoud is hier belangrijk omdat deze namen vaak in code worden gebruikt voor vergelijkingen.

Door deze naamgevingsconventies consequent toe te passen, creëert u een project waarin assets gemakkelijk vindbaar zijn, hun functie duidelijk is, en teamleden efficiënt kunnen samenwerken zonder verwarring over de locatie of het doel van specifieke elementen.