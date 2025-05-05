---
layout: default
title: Opzethandleiding
nav_order: 1
---

# Opzethandleiding

Deze gids leidt u door het proces van het opzetten van de ontwikkelomgeving voor het maken van AR-applicaties voor de Meta Quest 3.
Volg deze stappen om uw ontwikkelomgeving gereed te maken.

## Inhoud
- [Vereisten](#vereisten)
- [Stap 1: Installeer Unity Hub](#stap-1-installeer-unity-hub)
- [Stap 2: Installeer Unity Editor](#stap-2-installeer-unity-editor)
- [Stap 3: Configureer IDE](#stap-3-configureer-ide)
- [Stap 4: Maak een Meta-Developer-account aan](#stap-4-maak-een-meta-developer-account-aan)
- [Stap 5: Configureer de Meta Quest 3-headset](#stap-5-configureer-de-meta-quest-3-headset)
- [Stap 6: Installeer de Meta Quest Developer Hub](#stap-6-installeer-de-meta-quest-developer-hub)

## Vereisten

- **Besturingssysteem**: Windows 10/11 (64-bit), macOS 10.15 of nieuwer, of Ubuntu 20.04/22.04
- **CPU**: Ondersteuning voor SSE2-instructieset
- **GPU**: Grafische kaart met DX10-, DX11-, of DX12-mogelijkheden
- **RAM**: Minimaal 8GB, aanbevolen 16GB of meer
- **Opslagruimte**: Ten minste 10GB vrije ruimte voor installatie
- **Versiebeheer**: Dit document behandelt niet het installeren van Git of tools zoals GitHub Desktop, hoewel deze wel vereist zijn als u versiebeheer wilt toepassen.

## Stap 1: Installeer Unity Hub

De Unity Hub is een beheertool die helpt met het organiseren van Unity-projecten en het beheren van verschillende Unity Editor-versies.

1. Ga naar de [Unity Download-pagina](https://unity.com/download)
2. Klik op de **Download**-knop voor het geschikte besturingssysteem (Windows, Linux, Mac)
3. Voer de installer uit en volg de instructies
4. Start Unity Hub na installatie
5. Log in met uw Unity-ID (creëer er een als u nog geen ID hebt)

> **Note**: Unity biedt verschillende licentie-typen. Voor persoonlijk gebruik of kleine teams is de Personal-licentie gratis. Voor commerciële projecten heeft u mogelijk een andere licentie nodig.

## Stap 2: Installeer Unity Editor

Wanneer de Unity Hub is geïnstalleerd, moet u de Unity Editor installeren.

1. Ga in Unity Hub naar het **Installs**-tabblad
2. Klik op de **Install Editor**-knop
3. Selecteer **Unity (2022.3.60f1) LTS (Long Term Support)** voor de stabiliteit
4. Selecteer de volgende modules om te installeren:
   - Microsoft Visual Studio Community 2022
   - Android Build Support
5. Klik op **Install** en wacht tot de installatie klaar is

> **Note**: Het selecteren van de IDE Microsoft Visual Studio Community 2022 is aangeraden, maar mocht u een voorkeur hebben, kunt u een andere IDE installeren.

## Stap 3: Configureer IDE

U gaat nu de IDE instellen die u wilt gebruiken. Hieronder volgt de instructie voor Visual Studio.
Raadpleeg de officiële documentatie van uw gekozen IDE voor Unity Development-modules/extensies.

1. Start Visual Studio Installer
2. Bij de eerste keer dat u de installer opstart, moet u de licentievoorwaarden accepteren
3. Klik bij Visual Studio Community 2022 op **Modify**
4. Vink in het **Workloads**-tabblad de optie **Game Development with Unity** aan
5. Navigeer naar het tabblad **Individual Component**
6. Zoek naar **Unity**
7. Vink de optie **Visual Studio Tools for Unity** aan
8. Klik rechts onderin op **Modify**

> **Note**: Na het aanpassen van uw IDE kan het zijn dat de computer opnieuw moet worden opgestart.

## Stap 4: Maak een Meta-Developer-account aan

Om te kunnen ontwikkelen voor de Meta Quest 3, moet u een Meta-Developer-account aanmaken.

1. Ga naar het [Meta Quest Developer Dashboard](https://developers.meta.com/horizon/manage/)
2. Creëer een Meta-account of log in met uw bestaande account
3. Verifieer uw Meta Horizon-ontwikkelaarsaccount door tweestapsverificatie in te stellen door uw telefoonnummer in te voeren of door uw creditcard te gebruiken
4. Sluit u aan bij een organisatie of maak er een aan
   - Om u aan te sluiten bij een organisatie:
      1. Vul niets in bij de organisatienaam. De organisatiebeheerder moet u uitnodigen om toegang te krijgen tot de organisatie
      2. U ontvangt een e-mail met een uitnodiging. Klik op de link in de e-mail om u aan te sluiten bij de organisatie
   - Om een organisatie aan te maken:
      1. Vul de organisatienaam in en klik op de knop **Verzenden**

## Stap 5: Configureer de Meta Quest 3-headset

U gaat nu de headset gereedmaken voor ontwikkeling.

1. Zorg dat de headset volledig is opgeladen en ingeschakeld
2. Download de Meta Horizon-app op uw smartphone
3. Sta toe dat de app bluetooth-apparaten kan zoeken als dit gevraagd wordt
4. Log in met het Meta-account dat u in stap 4 hebt aangemaakt
5. Kies de optie **Een headset instellen**
6. Volg de instructies op het scherm om de headset te koppelen
7. Zet de headset aan en volg de instructies in de bril om de headset in te stellen

Ontwikkelingsmodus inschakelen:
1. Zorg dat uw headset is ingeschakeld en verbonden met uw smartphone
2. Open de Meta Horizon-app op uw smartphone
3. Navigeer naar **Menu > Apparaten** en selecteer uw headset
4. Klik op **Headsetinstellingen > Ontwikkelaarsmodus** en schakel deze in
5. Zet de headset op en ga naar **Instellingen > Geavanceerd** en schakel de optie **MTP-melding** in

## Stap 6: Installeer de Meta Quest Developer Hub

Om de functies van de Meta Quest Developer Hub (MQDH) te gebruiken, moet u deze eerst installeren en uw Meta Quest-headset verbinden met uw ontwikkelmachine:

1. Download en installeer de Meta Quest Developer Hub-applicatie voor [macOS](https://developers.meta.com/horizon/downloads/package/oculus-developer-hub-mac) of [Windows](https://developers.meta.com/horizon/downloads/package/oculus-developer-hub-win)
2. Open de applicatie en log in op het Meta-account dat u in stap 4 hebt aangemaakt

De headset verbinden met Meta Quest Developer Hub:
1. Zorg ervoor dat uw headset is ingeschakeld en verbonden met uw computer via USB-C
2. Wanneer er wordt gevraagd om de computer toegang te geven tot USB debugging, klik op **Toestaan** in de headset
3. Controleer of de headset verbonden is met uw computer:
   1. Klik in het linkernavigatiepaneel op **Apparaatbeheer**
   2. Kijk of uw headset wordt weergegeven in de lijst met apparaten
   3. Als de headset goed is aangesloten, ziet u bij de headset een groene Actief-aanduiding
