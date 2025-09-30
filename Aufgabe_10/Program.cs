namespace Aufgabe_10;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Zahl:");
        int zahl = Convert.ToInt32(Console.ReadLine());
        int sum = BerechneQuersumme(zahl);
        Console.WriteLine(sum);
    }

    static int BerechneQuersumme(int zahl)
    {
        int sum = 0;
        while (zahl != 0)
        {
            sum = sum + (zahl % 10);
            zahl = zahl / 10;
        }

        return sum;
    }
}