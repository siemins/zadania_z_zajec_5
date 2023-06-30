using System;

enum Rzadkosc
{
    Powszechny,
    Rzadki,
    Unikalny,
    Epicki
}

enum TypPrzedmiotu
{
    Bron,
    Zbroja,
    Amulet,
    Pierscien,
    Helm,
    Tarcza,
    Buty
}

struct Przedmiot
{
    public double Waga;
    public int Wartosc;
    public Rzadkosc KlasaRzadkosci;
    public TypPrzedmiotu Typ;
    public string NazwaWlasna;

    public void Wypelnij(double waga, int wartosc, Rzadkosc klasaRzadkosci, TypPrzedmiotu typ, string nazwaWlasna)
    {
        Waga = waga;
        Wartosc = wartosc;
        KlasaRzadkosci = klasaRzadkosci;
        Typ = typ;
        NazwaWlasna = nazwaWlasna;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine("Przedmiot: " + NazwaWlasna);
        Console.WriteLine("Typ: " + Typ);
        Console.WriteLine("Rzadkosc: " + KlasaRzadkosci);
        Console.WriteLine("Waga: " + Waga);
        Console.WriteLine("Wartosc: " + Wartosc + " sztuk zlota");
        Console.WriteLine();
    }
}

class Program
{
    static Random random = new Random();

    static Przedmiot LosujPrzedmiot(Przedmiot[] przedmioty)
    {
        double losowaRzadkosc = random.NextDouble();
        Rzadkosc wylosowanaRzadkosc;

        if (losowaRzadkosc < 0.6)
            wylosowanaRzadkosc = Rzadkosc.Powszechny;
        else if (losowaRzadkosc < 0.85)
            wylosowanaRzadkosc = Rzadkosc.Rzadki;
        else if (losowaRzadkosc < 0.95)
            wylosowanaRzadkosc = Rzadkosc.Unikalny;
        else
            wylosowanaRzadkosc = Rzadkosc.Epicki;

        var dostepnePrzedmioty = przedmioty.Where(p => p.KlasaRzadkosci == wylosowanaRzadkosc).ToArray();
        int losowyIndeks = random.Next(dostepnePrzedmioty.Length);

        return dostepnePrzedmioty[losowyIndeks];
    }

    static void Main(string[] args)
    {
        Przedmiot[] przedmioty = new Przedmiot[5];

        przedmioty[0].Wypelnij(1.5, 100, Rzadkosc.Powszechny, TypPrzedmiotu.Bron, "Miecz");
        przedmioty[1].Wypelnij(2.0, 250, Rzadkosc.Rzadki, TypPrzedmiotu.Zbroja, "Zbroja płytowa");
        przedmioty[2].Wypelnij(0.5, 500, Rzadkosc.Unikalny, TypPrzedmiotu.Pierscien, "Pierścień mocy");
        przedmioty[3].Wypelnij(1.0, 1000, Rzadkosc.Epicki, TypPrzedmiotu.Helm, "Helm nieśmiertelności");
        przedmioty[4].Wypelnij(0.8, 50, Rzadkosc.Powszechny, TypPrzedmiotu.Buty, "Buty skoczka");

        Przedmiot losowyPrzedmiot = LosujPrzedmiot(przedmioty);
        losowyPrzedmiot.WyswietlInformacje();

        Console.ReadLine();
    }
}

