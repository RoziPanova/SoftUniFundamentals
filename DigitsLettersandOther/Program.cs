using System;

namespace DigitsLettersandOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string numbers = ""; string letters = ""; string special = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsNumber(input[i]))
                {
                    numbers += input[i];
                }
                else if (char.IsLetter(input[i]))
                {
                    letters += input[i];
                }
                else { special += input[i]; }
            }
            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(special);
        }
    }
}
