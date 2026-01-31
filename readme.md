# System Zarządzania Zasobami (Distributed Resource Management System)

Aplikacja rozproszona stworzona w ramach projektu zaliczeniowego. System symuluje zarządzanie zasobami w firmie, wykorzystując architekturę Klient-Serwer, komunikację w czasie rzeczywistym oraz nowoczesne praktyki DevOps.

##  Główne Funkcjonalności

Projekt realizuje wymagania stawiane nowoczesnym aplikacjom rozproszonym:

* **Architektura Rozproszona:** Podział na Backend (API), Frontend (Blazor) i Współdzieloną Bibliotekę (Shared).
* **Komunikacja Real-Time:** Wykorzystanie **SignalR** do natychmiastowej synchronizacji danych między wszystkimi podłączonymi klientami (bez konieczności odświeżania strony).
* **Interfejs Użytkownika:** Responsywny UI stworzony w technologii **Blazor WebAssembly**.
* **API REST:** Kontrolery obsługujące operacje CRUD (Create, Read).
* **Testy Jednostkowe:** Projekt testowy oparty na **xUnit** weryfikujący logikę biznesową.
* **CI/CD:** Skonfigurowane **GitHub Actions** do automatycznego budowania projektu przy każdym wypchnięciu zmian (Push/Pull Request).

##  Technologie

* **Platforma:** .NET 7.0
* **Backend:** ASP.NET Core Web API
* **Frontend:** Blazor WebAssembly
* **Komunikacja:** SignalR (WebSockets)
* **Testy:** xUnit
* **Repozytorium:** Git (Git Flow)

## Struktura Projektu

* `Server` - Logika biznesowa, API REST, Hub SignalR, Baza danych In-Memory.
* `Client` - Warstwa prezentacji (UI), formularze, widoki tabelaryczne.
* `Shared` - Współdzielone modele danych (DTO), używane przez Serwer i Klienta.
* `Tests` - Testy jednostkowe weryfikujące poprawność działania aplikacji.
* `.github/workflows` - Konfiguracja potoków CI/CD.

##  Instrukcja Uruchomienia

Aby poprawnie uruchomić system, wymagane jest jednoczesne działanie Serwera i Klienta.

### Wymagania wstępne
* .NET SDK 7.0
* Visual Studio 2022 (lub VS Code)

### Krok po kroku

1.  **Sklonuj repozytorium:**
    ```bash
    git clone [https://github.com/pjay320/App.git](https://github.com/TWOJ_NICK/SystemZasobow.git)
    ```
2.  **Otwórz rozwiązanie:**
    Uruchom plik `SystemZasobow.sln` w Visual Studio.
3.  **Skonfiguruj wielokrotne uruchamianie (Ważne!):**
    * Kliknij Prawym Przyciskiem Myszy na **Rozwiązanie 'SystemZasobow'**.
    * Wybierz **"Ustaw projekty startowe"** (Set Startup Projects).
    * Zaznacz **"Wiele projektów startowych"**.
    * Ustaw akcję **Uruchom** (Start) dla projektów:
        1.  `Server` (Musi być pierwszy!)
        2.  `Client`
4.  **Uruchom aplikację:**
    Kliknij przycisk **Start** (F5).

Otworzą się dwa okna: konsola serwera oraz przeglądarka z interfejsem klienta.

## ?? Testowanie

Aby uruchomić testy jednostkowe:
1.  Otwórz eksplorator testów w Visual Studio (Test -> Test Explorer).
2.  Kliknij **"Uruchom Wszystkie"**.
3.  Alternatywnie z konsoli: `dotnet test`.

## ?? Git Workflow

W projekcie zastosowano strategię gałęzi:
* `main` - wersja stabilna (produkcyjna).
* `develop` - główna gałąź rozwojowa.
* `feature/*` - gałęzie dla nowych funkcjonalności.

Każda zmiana jest weryfikowana przez automatyczny proces Build w GitHub Actions.
