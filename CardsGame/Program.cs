using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> deck2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                if (deck1[0] > deck2[0])
                {
                    deck1.Add(deck1[0]);
                    deck1.Add(deck2[0]);
                }
                else if (deck1[0] < deck2[0])
                {
                    deck2.Add(deck2[0]);
                    deck2.Add(deck1[0]);
                }
                deck1.Remove(deck1[0]);
                deck2.Remove(deck2[0]);
                if (deck1.Sum() == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {deck2.Sum()}");
                    break;
                }
                else if (deck2.Sum() == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {deck1.Sum()}");
                    break;
                }
            }
        }
    }
}
