using System;
using System.Collections.Generic;

namespace _5.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string header = Console.ReadLine();
            string article = Console.ReadLine();

             List<string> comment = new List<string>();

            string input = "";
            while ((input = Console.ReadLine()) != "end of comments")
            {
                comment.Add(input);
            }

            Console.WriteLine("<h1>");
            Console.WriteLine(header);
            Console.WriteLine("</h1>");


            Console.WriteLine("<article>");
            Console.WriteLine(article);
            Console.WriteLine("</article>");

            foreach (var item in comment)
            {
                Console.WriteLine("<div>");
                Console.WriteLine(item);
                Console.WriteLine("</div>");
            }
           
        }
    }
}
