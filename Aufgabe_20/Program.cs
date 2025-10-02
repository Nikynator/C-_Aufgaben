using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Aufgabe_20
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            while (b == true)
            {
                //Console.WriteLine("This is a Joke IPA:");

                WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");
                WebResponse response = request.GetResponse();

                using Stream responseStream = response.GetResponseStream();
                using StreamReader reader = new StreamReader(responseStream);
                string json = reader.ReadToEnd();

                JArray array = JArray.Parse(json);

                foreach (var joke in array)
                {
                    Console.WriteLine(joke["text"]);
                    Console.WriteLine("Noch ein Witz [j/n]");
                    string input = Console.ReadLine();
                    if (input == "n")
                    {
                        b = false;
                        Console.WriteLine("You terminated the program, from now on your Day isn't going to be fun it's going to be extremly sad!!!");
                    }
                }
            }
        }
    }
}