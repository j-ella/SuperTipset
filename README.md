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


## 📦 Installation & Körning

1. Klona projektet från GitHub.
2. Säkerställ att **SQL Server** och **SSMS** är installerade.
3. Kör SQL-skriptet nedan i SSMS för att skapa databasen och tabellerna.
4. Ändra `connectionString` i `App.config` till din SQL Server-instans.
5. Bygg och kör projektet i Visual Studio.



## 📜 SQL-skript – Skapa databas och tabeller
```sql
-- Skapa databasen
CREATE DATABASE SuperTipset;
GO
USE SuperTipset;
GO

-- Skapa tabellen Sporter
CREATE TABLE dbo.Sporter (
    SportId INT IDENTITY(1,1) PRIMARY KEY,
    Namn NVARCHAR(50) NOT NULL UNIQUE
);

-- Skapa tabellen Lag
CREATE TABLE dbo.Lag (
    LagId INT IDENTITY(1,1) PRIMARY KEY,
    SportId INT NOT NULL,
    Namn NVARCHAR(100) NOT NULL,
    CONSTRAINT FK_Lag_Sporter FOREIGN KEY (SportId) REFERENCES dbo.Sporter(SportId),
    CONSTRAINT UQ_Lag_Per_Sport UNIQUE (SportId, Namn)
);

-- Infoga standarddata för sporter
INSERT INTO dbo.Sporter (Namn) VALUES
(N'Fotboll'),
(N'Basket'),
(N'Ishockey');

-- Exempeldata för lag (kan ändras eller tas bort)
INSERT INTO dbo.Lag (SportId, Namn) VALUES
(1, N'AIK'),
(1, N'Djurgården'),
(2, N'Lakers'),
(2, N'Heat'),
(3, N'Frölunda'),
(3, N'Leksand');
