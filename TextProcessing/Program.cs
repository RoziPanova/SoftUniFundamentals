using System;

namespace TextProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ban = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var item in ban)
            {
                while (text.Contains(item))
                {
                    string replacestr = "";
                    for (int i = 0; i < item.Length; i++)
                    {
                        replacestr += "*";
                    }
                    text = text.Replace(item, replacestr);
                }
            }
            Console.WriteLine(text);
        }
    }
}
