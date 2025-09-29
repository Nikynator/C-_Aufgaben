using System.Diagnostics.Metrics;

namespace Aufgabe_08;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dein Kommentar:");
        string eingabe = Console.ReadLine();
        string final = eingabe.ToLower();
        string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch" };
        string[] EingabeSplit = final.Split(' ');
        int i = 0;
        foreach (string wort in forbiddenWords)
        {
            if (EingabeSplit.Contains(wort))
            {
                i++;
                //Console.WriteLine($"Das Wort: '{wort}' wurde in der Benutzereingabe gefunden.");
                Console.WriteLine($"There are {i} violations.");
            }
        }
    }
}