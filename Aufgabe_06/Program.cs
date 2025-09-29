namespace Aufgabe_06;

class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        int n = 1;
        int Number = 0;
        while (Number <= 99)
        {
            Number = i * n;
            i++;
            Console.Write($"{Number}");
            Console.Write('\t');
        }
        
    }
}