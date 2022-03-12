using System;
using System.Security.Cryptography;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputs; i++)
            {
                string input = Console.ReadLine();
                int nameStart = input.IndexOf("@")+1;
                int nameEnd = input.IndexOf("|");
                string name = input.Substring(nameStart, nameEnd-nameStart);
                int ageStart = input.IndexOf("#")+1;
                int ageEnd = input.IndexOf("*");
                string age = input.Substring(ageStart, ageEnd - ageStart);
                Console.WriteLine($"{ name} is { age } years old.");
            }
        }
    }
}
