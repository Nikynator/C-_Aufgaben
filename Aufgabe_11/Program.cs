namespace Aufgabe_11;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Zahl 1: ");
        int userNumber1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Zahl 2: ");
        int userNumber2 = Convert.ToInt16(Console.ReadLine());
        int sum1 = BerechneQuersumme1(userNumber1);
        if (userNumber1 > userNumber2)
        {
            int wechsel = userNumber1;
            userNumber1 = userNumber2;
            userNumber2 = wechsel;
        }
        for (int i = userNumber1; i<userNumber2 + 1; i++)
        {
            int sum2 = BerechneQuersumme1(i);
            if ( i % sum2 == 0)
            {
                Console.WriteLine($"{i}\t{sum2}\t{i/sum2}");
            }
        }

    }
    static int BerechneQuersumme1(int userNumber1)
    {
        int sum1 = 0;
        while (userNumber1 != 0)
        {
            sum1 = sum1 + (userNumber1 % 10);
            userNumber1 = userNumber1 / 10;
        }

        return sum1;
    }
}