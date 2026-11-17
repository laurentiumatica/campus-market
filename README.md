# Campus Market

Platformă de anunțuri second-hand între studenți (manuale, calculatoare, mobilier de cămin etc.), realizată în ASP.NET Core MVC pentru materia Dezvoltarea Aplicațiilor Web. Produsele se rezervă în platformă, iar plata și predarea se fac în afara aplicației.

## Tehnologii

- ASP.NET Core MVC (.NET 10)
- Entity Framework Core
- ASP.NET Core Identity
- Bootstrap

## Cerințe

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Rider sau Visual Studio 2022+
- Git

## Pornirea proiectului

1. Clonează repo-ul:
   ```
   git clone https://github.com/laurentiumatica/campus-market.git
   ```
2. Treci pe branch-ul `dev`:
   ```
   git checkout dev
   ```
3. Deschide `CampusMarket.sln` în Rider sau Visual Studio.
4. Rulează proiectul `CampusMarket` (butonul Run) sau din terminal, în folderul `CampusMarket`:
   ```
   dotnet run
   ```
5. Deschide în browser adresa afișată în consolă (de exemplu `http://localhost:5237`).

> Configurarea bazei de date (connection string în user-secrets, migrări, conturi demo) va fi completată pe parcursul proiectului.

## Branch-uri

- `main` – versiunea stabilă, pentru predare
- `dev` – branch-ul comun de lucru
- `(config|feature|test|docs)/...` – câte un branch pentru fiecare card din Trello

## Echipa

- Matica Laurențiu-Andrei
- Filip Bogdan
