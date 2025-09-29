namespace Aufgabe_02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Berechnung von Sekunden eines Monates in Abhängigkeit seiner Anzahl Tage");
        Console.Write("Wie viele Tage hat der Monat, für den Sie die Sekundenzahl brechnen wollen?");
        string eingabe1 = Console.ReadLine();
        int Zahl = Convert.ToInt16(eingabe1);
        if (Zahl > 27 && Zahl < 32)
        {
            int FinalNumber = Zahl * 24 * 60 * 60;
            Console.WriteLine($"Ein Monat mit {eingabe1} hat {FinalNumber}.");
        }
        else
        {
            Console.WriteLine($"Ungültige Eingabe. Ein Monate mit {Zahl} gibt es nicht.");
        }
    }
}
