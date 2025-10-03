using System.Runtime.InteropServices.JavaScript;

namespace X_Partnerarbeit;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*********************");
        Console.WriteLine("* Kontakte erfassen *");
        Console.WriteLine("*********************");
        int i = 0;
        int j = 0;
        int y = 0;
        string [] vornameArr = new string[100];
        string [] nachnameArr = new string[100];
        string [] emailArr = new string[100];
        try
        {
            while (i != 100)
            {
                i++;
                Console.WriteLine($"{i}. Kontakt");
                Console.Write("Vorname: ");
                string vorname = Console.ReadLine();
                Console.Write("Nachname: ");
                string nachname = Console.ReadLine();
                Console.Write("E-Mail: ");l
                string email = Console.ReadLine();
                Console.Write("Eingabe beenden? (j/n)");
                string beenden = Console.ReadLine();
                vornameArr [i] = vorname;
                nachnameArr [i] = nachname;
                emailArr [i] = email;
                
                if (beenden == "j")
                {
                    Console.Write("Wie sollen die Kontakte ausgegeben werden? Vor- oder Nachname zu erst ? (v/n)");
                    string descision = Console.ReadLine();
                    if (descision == "v")
                    {
                        while (j != i)
                        {
                            j++;
                            Console.WriteLine($"{vornameArr[j]} {nachnameArr[j]} ({emailArr[j]})");
                            if (j == i)
                            {
                                Console.Write($"The Programm has ended.");
                                i = 100;
                                break;
                            }
                        }
                    }
                    if (descision == "n")
                    {
                        while (y != i)
                        {
                            y++;
                            Console.WriteLine($"{nachnameArr[y]} {vornameArr[y]} ({emailArr[y]})");
                            if (y == i)
                            {
                                Console.Write($"The Programm has ended.");
                                i = 100;
                                break;
                            }
                        }
                    }
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Pleas add a valid Input");
        }
    }
}