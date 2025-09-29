namespace Aufgabe_02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Berechnung von Sekunden eines Monates in Abhängigkeit seiner Anzahl Tage:");
        Console.Write("Wie viele Tage hat der Monat, für den Sie die Sekundenzahl brechnen wollen?");
        string eingabe1 = Convert.ToString(Console.ReadLine());
        int Zahl = 0;
        if (int.TryParse(eingabe1, out Zahl))
        {
            int Zahl1 = Convert.ToInt16(eingabe1);
            if (Zahl1 > 27 && Zahl1 < 32)
            {
                int FinalNumber = Zahl1 * 24 * 60 * 60;
                Console.WriteLine($"Ein Monat mit {eingabe1} hat {FinalNumber}.");
            }
            else
            {
                Console.WriteLine($"Ungültige Eingabe. Ein Monate mit {eingabe1} gibt es nicht.");
            }
        }
        else
        {
            Console.WriteLine($"Eingabefehler. Bitte geben Sie eine Zahl valide ein.");
        }
    }
}
