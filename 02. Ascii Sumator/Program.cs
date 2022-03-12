using System;

namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int begin = char.Parse(Console.ReadLine());
            int end = char.Parse(Console.ReadLine());
            char[] chars = Console.ReadLine().ToCharArray();
            int sum = 0;
            foreach (char item in chars)
            {
                if (item>begin && item<end)
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
