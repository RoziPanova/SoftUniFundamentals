using System;

namespace TriplesofLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                char firstChar = (char)('a' + i);
                for (int k = 0; k < n; k++)
                {
                    char secondChar = (char)('a' + k);
                    for (int j = 0; j < n; j++)
                    {
                        char thirdChar = (char)('a' + j);
                        Console.WriteLine(firstChar.ToString()+secondChar.ToString()+thirdChar.ToString());
                    }
                }
                
            }
        }
    }
}
