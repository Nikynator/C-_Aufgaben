namespace Aufgabe_7;

class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        while (i <= 30)
        {
            i++;
            if (i % 3  == 0 || i % 5  == 0)
            {
                
                if (i == 30)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i + ",");
                }
            }
        }
        
    }
}