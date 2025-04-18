using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] Number = Console.ReadLine().ToCharArray();
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int current = 0;
            List<string> list = new List<string>();
            for (int i = Number.Length - 1; i >=0 ; i--)
            {
                current += int.Parse(Number[i].ToString()) * n;
                list.Insert(0,(current % 10).ToString());
                current /= 10;
            }
            if (current>0)
            {
                Console.WriteLine($"{current}{string.Join("",list)}");
            }
            else
            {
                Console.WriteLine($"{string.Join("", list)}");
            }
        }
    }
}
