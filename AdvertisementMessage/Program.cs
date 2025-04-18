using System;

namespace AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] author = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] city = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var randomP = new Random().Next(phrases.Length);
                var randomE = new Random().Next(events.Length);
                var randomA = new Random().Next(author.Length);
                var randomC = new Random().Next(city.Length);
                Console.WriteLine(phrases[randomP] + " " + events[randomE] + " " + author[randomA] + " - " + city[randomC]);
            }
        }
    }
}
