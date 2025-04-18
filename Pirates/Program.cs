using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<City> list = new List<City>();
            while (true)
            {
                string[] input = Console.ReadLine().Split("||");
                if (input[0] == "Sail") { break; }
                City city = list.FirstOrDefault(x => x.Name == input[0]);
                if (city != null)
                {
                    city.Population += int.Parse(input[1]);
                    city.Gold += int.Parse(input[2]);
                }
                else
                {
                    list.Add(new City
                    {
                        Name = input[0],
                        Population = int.Parse(input[1]),
                        Gold = int.Parse(input[2]),
                    });

                }
            }
            while (true)
            {
                string[] input = Console.ReadLine().Split("=>");
                if (input[0] == "End") { break; }
                City city = list.FirstOrDefault(x => x.Name == input[1]);
                if (input[0] == "Plunder")
                {
                    city.Population -= int.Parse(input[2]);
                    city.Gold -= int.Parse(input[3]);
                    Console.WriteLine($"{input[1]} plundered! {input[3]} gold stolen, {input[2]} citizens killed.");
                    if (city.Population <= 0 || city.Gold <= 0)
                    {
                        Console.WriteLine($"{input[1]} has been wiped off the map!");
                        list.Remove(city);
                    }
                }
                else
                {
                    if (int.Parse(input[2]) < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    city.Gold += int.Parse(input[2]);
                    Console.WriteLine($"{input[2]} gold added to the city treasury. {input[1]} now has {city.Gold} gold.");
                }
            }
            if (list.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {list.Count} wealthy settlements to go to:");
                foreach (City city in list)
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg ");
                }
            }
        }
    }
}
