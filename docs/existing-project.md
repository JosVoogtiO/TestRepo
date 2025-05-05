---
layout: default
title: Werk aan Bestaande Projecten
nav_order: 3
---

# Werk aan Bestaande Projecten

Deze handleiding beschrijft hoe u bestaande projecten in uw ontwikkelomgeving kunt integreren voor een soepel ontwikkelproces. Volg onderstaande stappen om het project klaar te maken voor gebruik.

## Inhoud
- [Vereisten](#vereisten)
- [Stap 1: Clone Repository](#stap-1-clone-repository)
- [Stap 2: Veranderen Build Platform](#stap-2-veranderen-build-platform)
- [Stap 3: Installeer de XR Provider Plugin](#stap-3-installeer-de-xr-provider-plugin)
- [Stap 4: Maken van een Build](#stap-4-maken-van-een-build)
- [Stap 5: Build op de Device zetten](#stap-5-build-op-de-device-zetten)
- [Belangrijke Informatie](#belangrijke-informatie)

## Vereisten

- **Unity Hub**: Moet al geïnstalleerd zijn.
- **Unity Editor**: Moet al geïnstalleerd zijn met de juiste versie (Unity 2022.3.60f LTS).
- **IDE**: Er moet een IDE zijn geïnstalleerd.
- **Meta Quest Developer Hub**: Moet al geïnstalleerd zijn en de gebruiker moet al ingelogd zijn.
- **Device Configuratie**: Het device is al geconfigureerd en gereed om aan de slag te gaan met applicaties.
- **Versiebeheer**: Ontwikkelaar moet Git geïnstalleerd hebben (evt. tools zoals GitHub Desktop) en toegevoegd zijn aan de repository.


## Stap 1: Clone Repository

Het klonen van een repository kan via de commandline of via de GitHub Desktop. 

**Methode 1: Commandline**:

1. Via de **Command Prompt** of **Git Bash** navigeer naar, de map waar u de repository wilt plaatsen
2. Voer het commando ```git clone https://github.com/gebruikersnaam/repository-naam.git``` uit, maar vervang de URL naar uw repository

**Methode 2: GitHub Desktop**:

1. Open GitHub Desktop
2. Klik op **File** in de menubalk en selecteer **Clone Repository**
3. Kies de repository die u wilt klonen, via de tab **URL** kunt u de URL plakken van de repository
4. Kies de lokale map waar u de repository wilt opslaan
5. Klik op **Clone**

## Stap 2: Veranderen Build Platform

Bij het klonen van de repository kan het voorkomen dat het project de instellingen niet meeneemt.
Als dit het geval is, doe het volgende:

1. In de Unity Hub, selecteer het gekloonde project
2. Start de Unity Editor en navigeer naar **File > Build Settings** om dit te openen
3. Onder **Platform**, kijk of **Android** is geselecteerd, zo niet, klik op **Switch Platform**

## Stap 3: Installeer de XR Provider Plugin

1. In de Unity Editor navigeer via de menubalk naar **Edit > Project Settings** om de **Project Settings**-venster te openen
2. Selecteer **XR Plug-in Management**
3. Als de XR Plugin Management niet is geïnstalleerd, selecteer **Install XR Plugin Management**
4. In de **Windows, Mac, Linux settings** tab, selecteer **OpenXR**
5. In de **Android Settings** tab, selecteer **OpenXR**
6. Sluit het Project Settings-venster

> **Note**: Via **Window > Package Manager** kunt u verifiëren of OOpenXR-plugin is geïnstalleerd


## Stap 4: Maken van een Build

1. Ga naar **File > Build Settings** in de Unity Editor om het Build Settings-venster te openen
2. In de instellingen, zorg dat het platform op **Android** staat
3. Zorg ervoor dat de instelling **Run Device** op "Default device" staat
4. Klik op **Build** om een build te maken
5. Selecteer een gewenste bestandslocatie en geef de build een naam
6. Mocht de build niet succesvol zijn, zorg er dan voor dat alle errors worden opgelost en doorloop stap 1 t/m 5

## Stap 5: Build op de Device zetten

1. Open de Meta Quest Developer Hub (MQDH) 
2. Klik op **Device Manager**
3. Verbind de headset met de computer via een USB-C-kabel
4. Klik op **Connect Device**
5. Klik op het type device waarmee u wilt verbinden
6. Klik op de specifieke naam van het device en wacht tot de computer het apparaat kan vinden
7. Log in met uw MQDH-account
8. Als het device verbonden is, kan er een build worden toegevoegd door te klikken op **Add Build**
9. Selecteer de build vanuit de bestandslocatie
10. Wacht tot de installatie is voltooid
11. Zet de headset op, en in het menu moet de applicatie staan die u heeft toegevoegd


## Belangrijke Informatie

Hier volgt informatie die de ontwikkelaar kan helpen bij eventuele problemen:

> **Troubleshoot**: De eerste keer dat de ontwikkelaar het project opent, ziet deze mogelijk niet de werkelijke scene, maar een compleet nieuwe scene. Als de ontwikkelaar navigeert naar de **Project** tab en daarin via **Assets > Scenes** gaat naar de werkelijke scene (dit kan een naam hebben zoals **MainScene**), dan ziet de ontwikkelaar de correcte scene.