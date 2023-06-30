using System;

// Definicja struktury Student
struct Student
{
    public string Imie;
    public string Nazwisko;
    public int NumerIndeksu;
    public DateTime DataUrodzenia;
    public string Adres;
}

// Definicja struktury Przedmiot
struct Przedmiot
{
    public string Nazwa;
    public string Kierunek;
    public int ECTS;
    public string Prowadzacy;
}

// Definicja struktury NauczycielAkademicki
struct NauczycielAkademicki
{
    public string Imie;
    public string Nazwisko;
    public string TytulNaukowy;
    public string Specjalizacja;
}

class Program
{
    static void Main()
    {
        // Tworzenie instancji struktury Student
        Student student = new Student();
        student.Imie = "Jan";
        student.Nazwisko = "Kowalski";
        student.NumerIndeksu = 12345;
        student.DataUrodzenia = new DateTime(2000, 1, 1);
        student.Adres = "ul. Akademicka 10";

        // Tworzenie instancji struktury Przedmiot
        Przedmiot przedmiot = new Przedmiot();
        przedmiot.Nazwa = "Programowanie";
        przedmiot.Kierunek = "Informatyka";
        przedmiot.ECTS = 5;
        przedmiot.Prowadzacy = "Dr. Nowak";

        // Tworzenie instancji struktury NauczycielAkademicki
        NauczycielAkademicki nauczyciel = new NauczycielAkademicki();
        nauczyciel.Imie = "Anna";
        nauczyciel.Nazwisko = "Nowak";
        nauczyciel.TytulNaukowy = "Dr. hab.";
        nauczyciel.Specjalizacja = "Informatyka";

        // Wyświetlanie informacji
        Console.WriteLine("Student: {0} {1}", student.Imie, student.Nazwisko);
        Console.WriteLine("Numer indeksu: {0}", student.NumerIndeksu);
        Console.WriteLine("Data urodzenia: {0}", student.DataUrodzenia.ToShortDateString());
        Console.WriteLine("Adres: {0}", student.Adres);

        Console.WriteLine("\nPrzedmiot: {0}", przedmiot.Nazwa);
        Console.WriteLine("Kierunek: {0}", przedmiot.Kierunek);
        Console.WriteLine("ECTS: {0}", przedmiot.ECTS);
        Console.WriteLine("Prowadzący: {0}", przedmiot.Prowadzacy);

        Console.WriteLine("\nNauczyciel: {0} {1}", nauczyciel.Imie, nauczyciel.Nazwisko);
        Console.WriteLine("Tytuł naukowy: {0}", nauczyciel.TytulNaukowy);
        Console.WriteLine("Specjalizacja: {0}", nauczyciel.Specjalizacja);
    }
}

