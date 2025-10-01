namespace Aufgabe_16._2;

class Program
{
    static void Main(string[] args)
    {
        bool Restart = true;
        while (Restart == true)
        {
            Random rnd = new Random();
            int RandomNumber = rnd.Next(1, 101);
            Console.WriteLine(RandomNumber);
            int versucheCounter = 0;
            int whileEnd = 1;
            while (whileEnd != RandomNumber)
            {
                versucheCounter++;
                Console.WriteLine("Geben Sie die Zahl von 1 bis 100 ein: ");
                string Guess = Console.ReadLine();
                int intGuess = Convert.ToInt16(Guess);

                if (intGuess == RandomNumber)
                {
                    Console.WriteLine("Du hast die Zahl erraten! Du hast " + versucheCounter + " Versuche gebraucht.");
                    bool y = false;

                    while (y == false)
                    {
                        Console.WriteLine("Wollen Sie noch ein Mal spielen? [y/n]");
                        string input = Console.ReadLine();
                        if (input == "y")
                        {
                            Console.WriteLine("Sie haben das Spiel neugestartet. ");
                            whileEnd = RandomNumber;
                            y = true;
                            Restart = true;
                        }
                        else if (input == "n")
                        {
                            Console.WriteLine("Das Spiel wurde Beendet.");
                            whileEnd = RandomNumber;
                            y = true;
                            Restart = false;
                        }
                        else
                        {
                            Console.WriteLine("Eingabefehler");
                            y = false;
                        }
                    }
                }
                else if (intGuess > RandomNumber)
                {
                    Console.WriteLine("Korrekte Zahl ist kleiner! ");
                }
                else if (intGuess < RandomNumber)
                {
                    Console.WriteLine("Korrekte Zahl ist grösser! ");
                }
            }
        }
    }
}