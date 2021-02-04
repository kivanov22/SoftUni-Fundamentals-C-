using System;

namespace _5.Digits_Letters_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string digits = "";
            string letters = "";
            string symbols = "";
            foreach (var letter in text)
            {
                if (char.IsDigit(letter))
                {
                    digits += letter;
                }
                else if (char.IsLetter(letter))
                {
                    letters += letter;
                }
                else if (char.IsPunctuation(letter))
                {
                    symbols += letter;
                }
                else if (char.IsSymbol(letter))
                {
                    symbols += letter;
                }
            }
            //Console.WriteLine(string.Concat(digits,letters,symbols));can be done but it print on one line
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}
