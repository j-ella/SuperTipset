# SuperTipset – Sportresultatgenerator


## 📋 Projektbeskrivning
SuperTipset är en C#-applikation utvecklad för att slumpa fram resultat för tre olika sporter: **Fotboll**, **Basket** och **Ishockey**.  
Projektet inkluderar ett grafiskt användargränssnitt (WinForms) och en SQL Server-databas för lagring av sporter och lag.

Applikationen ska:
- Generera slumpade matchresultat baserat på vald sport.
- Visa spelschema och poängtabell.
- Låta användaren lägga till nya lag.
- Lagra sporter och lag i SQL Server.


## 🎯 Funktionalitet

### Stödda sporter och poängintervall
- **Ishockey**: Mål mellan 0 och 6
- **Fotboll**: Mål mellan 0 och 3
- **Basket**: Mål mellan 50 och 120

### Matchup-format
Fyra valda lag spelar **alla mot alla** en gång:
1. Lag 1 – Lag 2  
2. Lag 3 – Lag 4  
3. Lag 1 – Lag 3  
4. Lag 2 – Lag 4  
5. Lag 1 – Lag 4  
6. Lag 2 – Lag 3

### Poängberäkning
- Vinst = 3 poäng  
- Oavgjort = 1 poäng  
- Förlust = 0 poäng

