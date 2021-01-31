using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace _3.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");

                string title = tokens[0];
                string content = tokens[1];
                string author = tokens[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
            }
            string criteria = Console.ReadLine();//sort by title,author or content 

            if (criteria == "title")//sort by this 
            {
                articles = articles.OrderBy(x => x.Title).ToList();//order by creates a new collection if not initiallized
            }
            else if (criteria == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();//orderBy function for Lists
            }
            else if (criteria == "author")
            {
                articles.Sort((c1, c2) => c1.Author.CompareTo(c2.Author));
            }
            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }

    }
    class Article
    {
        public Article(string title, string content, string author)//constructor which takes 3 things
        {
            Title = title;//like we connect them with Article articles.Title=title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()//override write and space ToString tab tab
        {
            return $"{Title} - {Content}: {Author}";//properties of the classes
        }
    }
}