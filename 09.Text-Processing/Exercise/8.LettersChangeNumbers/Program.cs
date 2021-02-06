﻿using System;

namespace _8.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            double result = 0;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //A12b s17G example

            for (int i = 0; i < text.Length; i++)
            {
                string currentElement = text[i];
                char firstLetter = currentElement[0];//A
                char lastLetter = currentElement[currentElement.Length - 1];//B

                double number = double.Parse(currentElement.Substring(1, currentElement.Length - 2));//12

                int firstElementIndex = alphabet.IndexOf(char.ToUpper(firstLetter));
                int secondElementIndex = alphabet.IndexOf(char.ToUpper(lastLetter));

                if ((int)firstLetter>=65 && (int)firstLetter<=90)
                {
                    number = number / (firstElementIndex+1);//0 cant be divided so we set to 1 
                }
                else
                {
                    number = number * (firstElementIndex + 1);
                }

                if ((int)lastLetter>=65 && (int)lastLetter<=90)
                {
                    number = number - (secondElementIndex + 1);
                }
                else
                {
                    number = number + (secondElementIndex + 1);
                }
                result += number;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
