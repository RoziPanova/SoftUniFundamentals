using System;

namespace PrintingTriangle
{
    internal class Program
    {
        static void Print(int start,int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Print(1, i);
            }
            for (int i = n-1; i >=1; i--)
            {
                Print(1, i);
            }
        }
    }
}
