using System;

namespace MultiplyEvensbyOdds
{
    internal class Program
    {
        static void MultipleOfEvenAndOdds(int number)
        {
            number=Math.Abs(number);
            string num = number.ToString();
            int evenSum = 0;
            int oddSum= 0;
            for (int i = 0; i <num.Length; i++)
            {
                if (int.Parse(num[i].ToString())%2==0)
                {
                    evenSum += int.Parse(num[i].ToString());
                }
                else
                {
                     oddSum+= int.Parse(num[i].ToString());
                }
            }
            Console.WriteLine(evenSum*oddSum);
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            MultipleOfEvenAndOdds(number);
        }
    }
}
