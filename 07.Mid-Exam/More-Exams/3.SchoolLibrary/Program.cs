using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SchoolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shelfBooks = Console.ReadLine().Split("&").ToList();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] command = input.Split(" | ");
                

                switch (command[0])
                {
                    case "Add Book":
                        string bookName = command[1];
                        if (!shelfBooks.Contains(bookName))//there was a continue
                        {
                            shelfBooks.Insert(0, bookName);
                        }
                        //else
                        //{
                            
                        //}
                        break;
                    case "Take Book":
                        string bookTake = command[1];
                        if (shelfBooks.Contains(bookTake))
                        {
                            shelfBooks.Remove(bookTake);
                        }
                        //else
                        //{
                        //    continue;
                        //}
                        break;
                    case "Swap Books"://two variants finx the index of the book or do a for loop
                        string book1 = command[1];
                        string book2 = command[2];

                        if (shelfBooks.Contains(book1) && shelfBooks.Contains(book2))
                        {
                            int book1Index = shelfBooks.FindIndex(x => x == book1);
                            int book2Index = shelfBooks.FindIndex(x => x == book2);

                            string currentElement = shelfBooks[book1Index];
                            shelfBooks[book1Index] = shelfBooks[book2Index];
                            shelfBooks[book2Index] = currentElement;
                        }
                        break;
                    case "Insert Book":
                        string insertBook = command[1];
                        shelfBooks.Add(insertBook);
                        break;
                    case "Check Book":
                        int indexCheckBook = int.Parse(command[1]);

                        if (indexCheckBook >= 0 && indexCheckBook <= shelfBooks.Count)
                        {
                            string bookCheck = "";
                            bookCheck = shelfBooks[indexCheckBook];
                            Console.WriteLine(bookCheck);
                        }
                        //else
                        //{
                        //    continue;
                        //}
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", shelfBooks));
        }
    }
}
