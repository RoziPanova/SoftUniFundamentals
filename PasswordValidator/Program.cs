using System;
using System.Threading;

namespace PasswordValidator
{
    internal class Program
    {
        static void IsValid(string pass)
        {
            bool flag = true;
            if (pass.Length < 6 || pass.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                flag = false;
            }
            int count = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsLetterOrDigit(pass[i]) == false)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                flag = false;
            }
            count = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsDigit(pass[i]))
                {
                    count++;
                }
            }
            if (count < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                flag = false;
            }
            if (flag==true)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            IsValid(pass);
        }
    }
}
