using System;

namespace _1.ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string text = Console.ReadLine();


                int firstIndex = text.IndexOf('@');
                int secondIndex = text.IndexOf('|');
                int thirdIndex = text.IndexOf('#');
                int fourthIndex = text.IndexOf('*');

                string findName = text.Substring(firstIndex + 1, secondIndex - firstIndex - 1);
                //firstIndex +1, means after this index, and the lenght is found by endIndex-firstIndex-1
                string findAge = text.Substring(thirdIndex + 1, fourthIndex - thirdIndex - 1);

                Console.WriteLine($"{findName} is {findAge} years old.");
            }


        }
    }
}
