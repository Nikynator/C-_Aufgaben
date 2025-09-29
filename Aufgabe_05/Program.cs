namespace Aufgabe_05;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Wie viele Kilometer möchtest du rennen? ");
        string eingabe1 = Convert.ToString(Console.ReadLine());
        double Zahl = Convert.ToInt16(eingabe1);
        if (Zahl > 42)
        {
            Console.WriteLine("Das schaffst du nicht!");
        }
        else
        {
            double AnzahlBahnrunden = Zahl * 1000.00 / 400.00;
            Console.Write($"Das sind {AnzahlBahnrunden} Runden. Bereit für den Lauf?(ja/nein)");
            string eingabe2 = Convert.ToString(Console.ReadLine());
            if (eingabe2 == "ja")
            {
                double i = 0.00;
                while (i <= AnzahlBahnrunden)
                {
                    Console.WriteLine($"Du läufst Runde {i}.");
                    i++;
                }
                Console.WriteLine("Du hast es geschafft");
            }
        }
    }
}