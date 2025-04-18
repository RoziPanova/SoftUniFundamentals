using System;
using System.Linq;

namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]path=Console.ReadLine().Split('\\');
            string[] file = path.Last().Split('.').ToArray();
            Console.WriteLine($"File name: {file.First()}");
            Console.WriteLine($"File extension: {file.Last()}");
        }
    }
}
