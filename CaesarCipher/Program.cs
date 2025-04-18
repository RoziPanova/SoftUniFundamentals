using System;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string enscripted = "";
            for (int i = 0; i < input.Length; i++)
            {
               char c= input[i];
                c +=(char)3;
                enscripted += c;
            }
            Console.WriteLine(enscripted);
        }
    }
}
