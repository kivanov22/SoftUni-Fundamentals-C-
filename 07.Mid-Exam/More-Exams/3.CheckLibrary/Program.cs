using System;

namespace _3.CheckLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            switch (command[0])
            {
                case "Add Book":
                    string bookName = command[1];
                    if (shelfBooks.Contains(bookName))
                    {
                        continue;
                    }
                    else
                    {
                        shelfBooks.Insert(0, bookName);
                    }
                    break;
                case "Take Book":
                    string bookTake = command[1];
                    if (shelfBooks.Contains(bookTake))
                    {
                        continue;
                    }
                    else
                    {
                        shelfBooks.Remove(bookTake);
                    }
                    break;
                case "Swap Books":
                    break;
                case "Insert Book":
                    break;
                case "Check Book":
                    break;
                default:
                    break;
            }
        }

    }
}
