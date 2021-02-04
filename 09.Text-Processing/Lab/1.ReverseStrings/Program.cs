using System;
using System.Linq;

namespace _1.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";//empty string 
            while ((input=Console.ReadLine())!="end")//we take the word from console till end
            {
                var reversedString = input.ToArray().Reverse();//var is char , input makes it to array and reverse it
                Console.WriteLine($"{input} = {string.Join("", reversedString)}");// we print with string join because of strings and array
            }
        }
    }
}
