using System;

public enum DniTygodnia
{
    Poniedzialek,
    Wtorek,
    Sroda,
    Czwartek,
    Piatek,
    Sobota,
    Niedziela
}

public enum EtapyPrania
{
    WstepnePlukanie,
    GłownePranie,
    Plukanie,
    Suszenie
}

public enum Posilki
{
    Sniadanie,
    DrugieSniadanie,
    Obiad,
    Podwieczorek,
    Kolacja
}

[Flags]
public enum BierkiSzachowe
{
    Brak = 0,
    Pionek = 1,
    Wieza = 2,
    Skoczek = 4,
    Goniec = 8,
    Hetman = 16,
    Krol = 32
}

class Program
{
    static void Main(string[] args)
    {
        DniTygodnia dzien = DniTygodnia.Wtorek;
        Console.WriteLine($"Dzisiejszy dzień tygodnia to: {dzien}");

        EtapyPrania etap = EtapyPrania.GłownePranie;
        Console.WriteLine($"Aktualny etap prania: {etap}");

        Posilki posilek = Posilki.Obiad;
        Console.WriteLine($"Czas na: {posilek}");

        BierkiSzachowe bierki = BierkiSzachowe.Pionek | BierkiSzachowe.Wieza | BierkiSzachowe.Goniec;
        Console.WriteLine($"Wybrane bierki szachowe: {bierki}");

        Console.ReadLine();
    }
}

