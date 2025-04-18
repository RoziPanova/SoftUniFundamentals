using System;

namespace CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]array=Console.ReadLine().Split(' ');
            string str1 = array[0];
            string str2 = array[1];
            int sum = 0;
            if (str1.Length>=str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    sum+= char.Parse(str1[i].ToString()) * char.Parse(str2[i].ToString());
                }
                for (int i = str1.Length-1; i >=str2.Length;i--)
                {
                    sum += char.Parse(str1[i].ToString());
                }
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    sum += char.Parse(str1[i].ToString()) * char.Parse(str2[i].ToString());
                }
                for (int i = str2.Length-1; i >=str1.Length; i--)
                {
                    sum += char.Parse(str2[i].ToString());
                }
            }
           
            Console.WriteLine(sum);
        }
    }
}
/*
Peter George
 */
