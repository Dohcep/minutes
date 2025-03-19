using System;

class Program
{
    static (int, int) ConvertirMinutes(int nbMin)
    {
        int heures = nbMin / 60;
        int minutes = nbMin % 60;
        return (heures, minutes);
    }

    static void Main()
    {
        var (h1, m1) = ConvertirMinutes(90);
        Console.WriteLine($"90 minutes = {h1} heure.s et {m1} minute.s");

        var (h2, m2) = ConvertirMinutes(150);
        Console.WriteLine($"150 minutes = {h2} heure.s et {m2} minute.s");
    }
}