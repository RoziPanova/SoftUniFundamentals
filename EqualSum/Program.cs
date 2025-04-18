using System;
using System.Linq;

namespace EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool flag=false;
            for (int i = 0; i < nums.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                for (int k = i+1; k < nums.Length; k++)
                {
                   sumRight += nums[k];
                }
                for (int j = i-1; j >= 0; j--)
                {
                    sumLeft += nums[j];
                }
                if (sumLeft==sumRight)
                {
                    Console.WriteLine(i);
                    flag= true;
                }
            }
            if (flag==false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
