using System;
using System.Security.Principal;

namespace _2.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(", ");
            Article article = new Article(tokens[0], tokens[1], tokens[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(": ");//which thing to do Edit,change author, title
                string command = cmdArgs[0];//command to perform edit,rename,change
                string argument = cmdArgs[1];//better is the second word

                switch (command)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(argument);
                        break;
                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }
            Console.WriteLine(article.ToString());
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


            public void Edit(string content)
            {
                Content = content;
            }

            public void ChangeAuthor(string author)
            {
                Author = author;
            }

            public void Rename(string title)
            {
                Title = title;
            }

            public override string ToString()//override write and space ToString tab tab
            {
                return $"{Title} - {Content}: {Author}";//properties of the classes
            }
        }
    }
}
