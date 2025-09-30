namespace Aufgabe14;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prüfen, ob es sich bei einem Jahr um ein Schaltjahr handelt.");
        Console.WriteLine("-------------------------------------------------------------");
        
        bool keypressed = false;
        while (keypressed == false)
        {
            string bin = (" ");
            int userNumber;
            int rest;
            int value;

        Console.Write("Eingabe Jahr (q to quit): ");
        int InputInt = Convert.ToInt32(Console.ReadLine());
        string input = InputInt.ToString();

            if (input == "q")
            {
                keypressed = true;
                Console.WriteLine("You pressed q which stopped the programm");
            }
            
        }
        if (InputInt % 4 == 0)
        {
            if (InputInt % 400 == 0)
            {
                Console.WriteLine($"Das Jahr {input} ist ein Schaltjahr");
            }
            else
            {
                Console.WriteLine($"Das Jahr {input} ist KEIN Schaltjahr");
            }
        }
        else
        {
            Console.WriteLine($"Das Jahr {input} ist KEIN Schaltjahr");
        }

    }
}