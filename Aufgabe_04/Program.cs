namespace Aufgabe_04;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Zahl eingeben: ");
        string eingabe = Console.ReadLine();
        
        int Zahl = 0;
        string[] Months = new string[12]; 
        Months[0] = "Januar";
        Months[1] = "Februar";
        Months[2] = "März";
        Months[3] = "April";
        Months[4] = "Mai";
        Months[5] = "Juni";
        Months[6] = "Juli";
        Months[7] = "August";
        Months[8] = "September";
        Months[9] = "October";
        Months[10] = "November";
        Months[11] = "December";
        if (int.TryParse(eingabe, out Zahl))
        {
            int i = Convert.ToInt16(eingabe);
            if (i >= 1 && i <= 12)
            {
                i = i - 1;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(Months[i]);
            }
            else
            {
                Console.WriteLine("Your Number isn't valid please choose a Number between 1 and 12.");
            }
        }
        else
        {
            Console.WriteLine("Your Number isn't valid please choose a Absolut Number.");
        }
    }
}