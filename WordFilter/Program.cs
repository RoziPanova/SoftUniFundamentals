using System;
using System.Linq;

namespace WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words=Console.ReadLine().Split(' ').Where(words=>words.Length%2==0).ToArray();
            Console.WriteLine(string.Join("\n",words));
        }
    }
}
