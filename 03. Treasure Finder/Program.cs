using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string find;
            while ((find = Console.ReadLine()) != "find")
            {
            char[] treasure = Console.ReadLine().ToCharArray();
                StringBuilder foundedTreasure = new StringBuilder();
                for (int i = 0; i < treasure.Length; i++)
                {
                    foundedTreasure.Append((char)(treasure[i] - key[i]));
                }
            }

        }
    }
}
