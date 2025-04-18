using System;

namespace VowelsCount
{
    internal class Program
    {
        static void CounterVouls(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'u' || word[i] == 'o' || word[i] == 'y' || word[i] == 'e' || word[i] == 'i')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            CounterVouls(word);
        }
    }
}
