using System;
using System.Reflection;

namespace TopNumber
{
    internal class Program
    {
        static void TopNumbers(int numbers)
        {
            for (int i = 0; i <= numbers; i++)
            {
                int sum = 0;
                bool flag = false;
                string number = i.ToString();
                for (int k = 0; k < number.Length; k++)
                {
                    sum += int.Parse(number[k].ToString());
                    if (int.Parse(number[k].ToString())%2!=0)
                    {
                        flag = true;
                    }
                }
                if (sum%8==0&&flag==true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            TopNumbers(number);
        }
    }
}
