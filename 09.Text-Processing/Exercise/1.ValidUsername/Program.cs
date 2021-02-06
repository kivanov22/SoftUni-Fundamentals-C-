using System;
using System.Linq;

namespace _1.ValidUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] userNames = Console.ReadLine().Split(", ");

            var input = Console.ReadLine().Split(", ");//var makes it a array 

            for (int i = 0; i < input.Length; i++)
            {
                var currentSymbol = input[i];

                if (IsValid(currentSymbol))
                {
                    Console.WriteLine(currentSymbol);
                }
            }
        }
        public static bool IsValid(string current)//method for checking validation 
        {
            //Has length between 3 and 16 characters
            //Contains only letters, numbers,hyphens and underscores

            return current.Length >= 3 &&
                current.Length <= 16 &&
                current.All(c => char.IsLetterOrDigit(c))||
                current.Contains("-")||current.Contains("_");
        }
    }
}
