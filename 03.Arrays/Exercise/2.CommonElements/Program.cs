using System;
using System.Linq;

namespace _2.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split().ToArray();//get two string arrays
            string[] arr2 = Console.ReadLine().Split().ToArray();

            string word = "";//storage for the word 

            foreach (var item in arr2)// go through second array
            {
                if (arr1.Contains(item))//check first array for word
                {
                    word += " " + item;//get the word
                  //  Console.Write($"{item}");
                }
            }
            Console.Write($"{word.Trim()}");//print word without white-space
        }
    }
}
