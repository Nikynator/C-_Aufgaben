using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bitte gib ein Geburtsdatum ein (TT.MM.JJJJ): ");
        Console.WriteLine(" ");
        string date = Console.ReadLine();

        if (DateTime.TryParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime geburtsdatum))
        {
            DateTime today = DateTime.Today; // heutiges Datum = 01.10.2025 (aus deiner Aufgabenstellung)
            
            if (geburtsdatum > today)
            {
                Console.WriteLine("Das Geburtsdatum liegt in der Zukunft!");
                return;
            }

            // Alter in Jahren korrekt berechnen
            int year = today.Year - geburtsdatum.Year;
            if (today.Month < geburtsdatum.Month || (today.Month == geburtsdatum.Month && today.Day < geburtsdatum.Day))
            {
                year--;
            }

            // Monaten
            int month = year * 12 + (today.Month - geburtsdatum.Month);
            if (today.Day < geburtsdatum.Day)
            {
                month--;
            }

            // Tagen
            TimeSpan differenz = today - geburtsdatum;
            int day = (int)differenz.TotalDays;

            // Wochen
            int week = day / 7;

            // Ausgabe
            Console.WriteLine($"Years: {year}");
            Console.WriteLine($"Months: {month}");
            Console.WriteLine($"Weeks: {week}");
            Console.WriteLine($"Days: {day}");
        }
        else
        {
            Console.WriteLine("Ungültiges Datum. Bitte im Format TT.MM.JJJJ eingeben.");
        }
    }
}