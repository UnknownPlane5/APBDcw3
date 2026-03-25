Instrukcja uruchomienia
1.Sklonuj repozytorium.
2.Otwórz projekt w środowisku Visual Studio lub JetBrains Rider.
3.Uruchom projekt APBDcw3. Wszystko zostanie wyświetlone na konsoli
Opis:
Aplikacja jest systemem konsolowym, służącym do obsługi uczelnianej wypożyczalni sprzętu. 
Program pozwala na rejestrowanie urządzeń, zarządzanie bazą użytkowników, proces wypożyczania i zwrotów oraz generowanie raportów o stanie systemu.
System automatycznie kontroluje dostępność sprzętu oraz limity wypożyczeń przypisane do różnych typów użytkowników.

Wykorzystano podział na 3 obszary:
1.Klasy przechowujące stan i dane systemu
2.Logika Biznesu(RentalService)
3.Program.cs testujący program
Wykorzystano klasy abstrakcyjne(User i Device) rozdzielając klasy na 2 hierarchie:
1.Użytkowników(Student, Employee)
2.Sprzętu(Laptop, Projektor, Camera)

Fukcjonalności:
-Unikalne ID: System automatycznie generuje nowy identyfikator dla każdego nowego sprzętu lub użytkownika 
dodanego do sytemu
-Naliczenie kar: Za każdy dzień zwłoki po terminie zwrotu naliczana jest stała kara w wysokości 10 zł.
-Walidacja: System blokuje próby wypożyczenia sprzętu niedostępnego (np. w serwisie) lub przekroczenie limitu przez użytkownika.
