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
            char[] treasure = find.ToCharArray();
                StringBuilder foundedTreasure = new StringBuilder();
                for (int i = 0; i < treasure.Length-1; i++)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (i<treasure.Length)
                        {
                        foundedTreasure.Append((char)(treasure[i] - key[j]));
                        i++;
                        }
                    }
                    i--;
                }
                string[] getTypeOfTreasure = foundedTreasure.ToString().Split("&"); 
                string type = getTypeOfTreasure[1].ToString();
                string[] getCoordinates = foundedTreasure.ToString().Split('<','>'); 
                string coordinates = getCoordinates[1];
                Console.WriteLine($"Found {type} at {coordinates}");
            }
        }
    }
}
