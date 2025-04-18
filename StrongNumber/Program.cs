using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int current = 1;
                if (int.Parse(number[i].ToString())!=0)
                {
                    for (int j = int.Parse(number[i].ToString()); j >0; j--)
                    {
                        current *= j;
                    }
                    sum += current;
                }
                else
                {
                    sum += 1;
                }
            }
            if (number==sum.ToString())
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
