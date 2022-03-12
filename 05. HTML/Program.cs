using System;
using System.Collections.Generic;
namespace _05._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            List<string> comments = new List<string>();
            string comment;
            while ((comment = Console.ReadLine()) != "end of comments")
            {
                comments.Add(comment); 
            }
            Console.WriteLine($"<h1>\n    {title}\n</h1>");
            Console.WriteLine($"<article>\n    {content}\n</article>");
            foreach (var item in comments)
            {
                Console.WriteLine($"<div>\n    {item}\n</div>");
            }
        }
    }
}
