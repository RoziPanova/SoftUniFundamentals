using System;

namespace ValidUsername
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array=Console.ReadLine().Split(", ");
            foreach (var item in array)
            {
                bool flag = true;
                if (item.Length>=3&&item.Length<=16)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if ((item[i] == '-' || item[i] == '_' )|| char.IsLetterOrDigit(item[i]))
                        {
                            continue;
                        }
                        else
                        {
                            flag= false;
                            break;
                        }
                    }
                    if (flag) { Console.WriteLine(item); }
                }
            }
        }
    }
}
