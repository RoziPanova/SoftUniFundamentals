using System;

namespace BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
            double max = double.MinValue;
            string biggest = "";
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                float radious=float.Parse(Console.ReadLine());
                int height=int.Parse(Console.ReadLine());
                double size=Math.PI*radious*radious*height;
                if (max<size)
                {
                    max = size;
                    biggest = name;
                }
            }
            Console.WriteLine(biggest);
        }
    }
}
