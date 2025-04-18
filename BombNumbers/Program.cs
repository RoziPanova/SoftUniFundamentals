using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < list.Count; i++)
            {
                int start = 0;
                int finish = 0;
                if (list[i] == array[0])
                {
                    start= i - array[1];
                    if (start<0)
                    {
                        start = 0;
                    }
                    finish = i + array[1];
                    if (finish>list.Count)
                    {
                        finish = list.Count;
                    }
                    for (int k = start; k < finish+1; k++)
                    {
                        list[k] = 0;
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum);
        }
    }
}
