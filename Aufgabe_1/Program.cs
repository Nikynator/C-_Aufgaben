namespace Aufgabe_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dieses Programm berechnet die Summe von zwei Zahlen.");
        Console.Write("Zahl 1: ");
        string eingabe1 = Console.ReadLine();
        Console.Write("Zahl 2: ");
        string eingabe2 = Console.ReadLine();
        int Zahl1 = Convert.ToInt16(eingabe1);
        int Zahl2 = Convert.ToInt16(eingabe2);
        Console.WriteLine($"Summe: {Zahl1+Zahl2}");
    }
}