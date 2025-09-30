namespace Aufgab1_15._1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Breites des Stammes: ");
        string inputBreite = Console.ReadLine();
        int intInputBreite = Convert.ToInt16(inputBreite);
        Console.Write("Höhe des Stammes: ");
        string inputHöhe = Console.ReadLine();
        int intInputHöhe = Convert.ToInt16(inputHöhe);
        Console.Write("Höhe der Krone: ");
        string inputKrone = Console.ReadLine();
        int intInputKrone = Convert.ToInt16(inputKrone);
        string str = "";
        for (int i = 0; i <= intInputBreite; i++)
        {
            for (int j = 0; j <= intInputBreite; j++)
            {
                str += "";
            }

            for (int K = 0; K < 2 * i - 1; K++)
            {
                str += " *";
            }
            str += "\n";
        }

        Console.WriteLine($"{str}");
        
    }
}