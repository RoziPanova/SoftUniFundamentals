using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]words=Console.ReadLine().ToLower().Split(' ').ToArray();
            Dictionary<string,int>counts=new Dictionary<string,int>();
            foreach (string word in words) 
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else {
                    counts.Add(word, 1);
                }
            }
            foreach (var item in counts) 
            {
                if (item.Value%2!=0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
