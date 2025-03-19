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
        Console.Write("Entrez un nombre de minutes : ");
        if (int.TryParse(Console.ReadLine(), out int nbMin))
        {
            var (heures, minutes) = ConvertirMinutes(nbMin);
            Console.WriteLine($"{nbMin} minutes = {heures} heure(s) et {minutes} minute(s)");
        }
        else
        {
            Console.WriteLine("Veuillez entrer un nombre valide.");
        }
    }
}    
