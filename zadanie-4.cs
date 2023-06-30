using System;

// Definicja typu wyliczeniowego dla płci
enum Gender
{
    Male,
    Female
}

// Definicja struktury Student
struct Student
{
    public string LastName;
    public int StudentNumber;
    public double Grade;
    public Gender Gender;
}

class Program
{
    static void Main(string[] args)
    {
        // Tworzenie grupy 5 studentów
        Student[] group = new Student[5];

        // Wypełnianie instancji studentów danymi
        for (int i = 0; i < group.Length; i++)
        {
            FillStudentData(ref group[i]);
        }

        // Wyświetlanie informacji o studentach
        Console.WriteLine("Grupa studentów:");
        for (int i = 0; i < group.Length; i++)
        {
            DisplayStudentInfo(group[i]);
        }

        // Obliczanie średniej ocen
        double averageGrade = CalculateAverageGrade(group);
        Console.WriteLine("Średnia ocen w grupie: " + averageGrade.ToString("F2"));
    }

    static void FillStudentData(ref Student student)
    {
        Console.Write("Podaj nazwisko studenta: ");
        student.LastName = Console.ReadLine();

        Console.Write("Podaj numer albumu: ");
        student.StudentNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj ocenę studenta: ");
        double grade = Convert.ToDouble(Console.ReadLine());

        // Sprawdzanie poprawności oceny
        if (grade < 2.0)
            student.Grade = 2.0;
        else if (grade > 5.0)
            student.Grade = 5.0;
        else
            student.Grade = grade;

        Console.Write("Podaj płeć studenta (0 - Mężczyzna, 1 - Kobieta): ");
        int genderInput = Convert.ToInt32(Console.ReadLine());

        // Sprawdzanie poprawności wprowadzonej płci
        if (genderInput == 0)
            student.Gender = Gender.Male;
        else
            student.Gender = Gender.Female;

        Console.WriteLine();
    }

    static void DisplayStudentInfo(Student student)
    {
        string genderText = student.Gender == Gender.Male ? "Mężczyzna" : "Kobieta";
        Console.WriteLine($"Nazwisko: {student.LastName}, Numer albumu: {student.StudentNumber}, " +
            $"Ocena: {student.Grade.ToString("F2")}, Płeć: {genderText}");
    }

    static double CalculateAverageGrade(Student[] group)
    {
        if (group.Length == 0)
            return 0;

        double sum = 0;
        foreach (var student in group)
        {
            sum += student.Grade;
        }

        return sum / group.Length;
    }
}

