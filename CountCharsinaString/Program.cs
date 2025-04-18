using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsinaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string>words=Console.ReadLine().Split(" ").ToList();
            Dictionary<char,int> charCount = new Dictionary<char,int>();
            for (int i = 0; i < words.Count; i++)
            {
                for (int k = 0; k < words[i].Length; k++)
                {
                    string word = words[i];
                    if (charCount.ContainsKey(word[k])==false)
                    {
                        charCount.Add(word[k],1);
                    }
                    else
                    {
                        charCount[word[k]]++;
                    }
                }
            }
            foreach (var item in charCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
