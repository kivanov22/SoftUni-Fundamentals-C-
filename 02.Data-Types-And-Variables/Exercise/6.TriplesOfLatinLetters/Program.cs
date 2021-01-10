using System;

namespace _6.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char firstChar = (Char)(97 + i);
                        char secondChar = (Char)(97 + j);
                        char thirdChar = (Char)(97 + k);

                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                        
                       
                       
                    }
                }
            }

        }
    }
}
