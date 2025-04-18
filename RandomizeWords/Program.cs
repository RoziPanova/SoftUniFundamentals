using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> word=Console.ReadLine().Split(' ').ToList();
            var random=new Random();
            for (int i = 0; i < word.Count; i++)
            {
                int randomised = random.Next(0,word.Count);
                Console.WriteLine(word[randomised]);
                word.Remove(word[randomised]);
                i--;
            }
        }
    }
}
