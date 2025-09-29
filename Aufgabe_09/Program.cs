namespace Aufgabe_09;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Number:");
        int n = Convert.ToInt32(Console.ReadLine());
        string bin = ("");
        int rest;
        int werte;
        while (n != 0)
        {
            rest = n % 2;
            bin = rest + bin;
            werte = n / 2;
            n = werte;
            if (n==0)
            {
                Console.WriteLine(bin);
            }
        }
        bool kaypressed = false;
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        if (keyInfo.KeyChar == 'q')
        {
            kaypressed = true;
            Console.WriteLine("Your done buddy boy");
        }
        else
        {
            kaypressed = false;
        }
    }
}