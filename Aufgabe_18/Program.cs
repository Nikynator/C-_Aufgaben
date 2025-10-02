namespace Aufgabe_18;

class Program
{
    static int a = 0;
    static int e = 0;
    static int i = 0;
    static int o = 0;
    static int u = 0;
    static int ä = 0;
    static int ü = 0;
    static int ö = 0;
    
    static void Main(string[] args)
    {
        Console.WriteLine("Deine Eingabe:");
        string eingabe = Console.ReadLine();
        string eingabeScan = eingabe.ToLower();
        //char charEingabeScan = Convert.ToChar(eingabeScan);
        //char [] arrayCharEingabeScan = eingabeScan.ToCharArray();
        string vokalListe = "aeiouöüä";
        methodScan(eingabeScan,vokalListe);
        Console.WriteLine($"Dein Text hat total {a+e+i+o+u+ä+ö+ü} Vokale.");
        Console.WriteLine($"Der Buchstabe a kommt {a} mal vor.");
        Console.WriteLine($"Der Buchstabe e kommt {e} mal vor.");
        Console.WriteLine($"Der Buchstabe i kommt {i} mal vor.");
        Console.WriteLine($"Der Buchstabe o kommt {o} mal vor.");
        Console.WriteLine($"Der Buchstabe u kommt {u} mal vor.");
        Console.WriteLine($"Der Buchstabe ä kommt {ä} mal vor.");
        Console.WriteLine($"Der Buchstabe ü kommt {ü} mal vor.");
        Console.WriteLine($"Der Buchstabe ö kommt {ö} mal vor.");
    }

    static int methodScan(string eingabeScan, string vokalListe)
    {
        foreach (char Buchstaben in eingabeScan)
        {
            if (vokalListe.Contains(Buchstaben))
            {
                if (Buchstaben == 'a')
                {
                    a++;
                }
                if (Buchstaben == 'e')
                {
                    e++;
                }
                if (Buchstaben == 'i')
                {
                    i++;
                }
                if (Buchstaben == 'o')
                {
                    o++;
                }
                if (Buchstaben == 'u')
                {
                    u++;
                }
                if (Buchstaben == 'ä')
                {
                    ä++;
                }
                if (Buchstaben == 'ö')
                {
                    ö++;
                }
                if (Buchstaben == 'ü')
                {
                    ü++;
                }
            }
        }
        return 0;
    }
}