/*
3
cute
adorable
cute
charming
smart
clever
 */
using System;
using System.Collections.Generic;

namespace WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<string, List<string>>();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym=Console.ReadLine();
                if (words.ContainsKey(word)==false)
                {
                    words.Add(word, new List<string>());
                    words[word].Add(synonym);
                }
                else
                {
                    words[word].Add(synonym);
                }
            }
            foreach (var item in words)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
        }
    }
}
