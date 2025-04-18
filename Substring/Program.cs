using System;

namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sub = Console.ReadLine();
            string word= Console.ReadLine();
            while (word.Contains(sub))
            {
               word=word.Remove(word.IndexOf(sub),sub.Length);
            }
            Console.WriteLine(word);
        }
    }
}
