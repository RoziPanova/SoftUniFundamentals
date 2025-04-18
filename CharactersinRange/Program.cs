using System;

namespace CharactersinRange
{
    internal class Program
    {
        static void Range(char first,char second)
        {
            if (first>second)
            {
                char holder = first;
                first = second;
                second = holder;
            }
            for (int i = first+1; i < second; i++)
            {
                Console.Write(char.ConvertFromUtf32(i).ToString()+' ');
            }
        }
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            Range(first, second);
        }
    }
}
