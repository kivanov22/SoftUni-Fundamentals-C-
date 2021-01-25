using System;

namespace _2.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int result= PrintVowels(input);
            Console.WriteLine(result);
        }

        static int PrintVowels(string input)
        {
            int count = 0;
            //A, E, I, O, U, and sometimes Y.

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == 'a')
                {
                    count++;
                }
                else if (currentChar=='e')
                {
                    count++;
                }
                else if (currentChar=='i')
                {
                    count++;
                }
                else if (currentChar=='o')
                {
                    count++;
                }
                else if (currentChar =='u')
                {
                    count++;

                }
                else if (currentChar=='y')
                {
                    count++;
                }

            }
            return count;
        }
    }
}
