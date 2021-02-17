using System;
using System.Text.RegularExpressions;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //string patternMesage = @"([\*|\@])(?<message>[A-Z][a-z]{2,})(\1): ([(?<num1>\d+)]|)([(?<num2>\d+)]|)([(?<num3>\d+)]|)";
            //string patternMesage = @"(\*|\@)([A-Z][a-z]{3,})(\1):\s([)(\d+)(])|([)(\d+)(])|([)(\d+)(])";
            string pattern = @"([*|@])(?<tag>[A-Za-z]{3,})(\1):\s([[])(?<mes1>(\w|\d.))([]])([|])([[])(?<mes2>(\w|\d.))([]])([|])([[])(?<mes3>(\w|\d.))([]])([|])";

            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());



            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();


                MatchCollection match = regex.Matches(input);

                if (match.Count==0)
                {
                    Console.WriteLine("Valid message not found!");
                }
                foreach (Match item in match)
                {
                    if (item.Success)
                    {
                        string command = item.Groups["tag"].Value;
                        char firstChar = char.Parse(item.Groups["mes1"].Value);
                        char secondChar =char.Parse( item.Groups["mes2"].Value);
                        char thirdChar = char.Parse(item.Groups["mes3"].Value);

                        int firstNum = firstChar;
                        int secondNum = secondChar;
                        int thirdNum = thirdChar;
                        //for (int j = 0; j < firstChar.Length; j++)
                        //{
                        //   char cur1 = firstChar[i];
                        //   firstNum = cur1;
                        //}
                        //for (int k = 0; k < secondChar.Length; k++)
                        //{
                        //    char cur2 = secondChar[k];
                        //    secondNum = cur2;

                        //}
                        //for (int b = 0; b < thirdChar.Length; b++)
                        //{
                        //    char curr3 = thirdChar[b];
                        //    thirdNum = curr3;
                        //}
                        //char first = char.Parse(firstChar);
                        //int second = char.Parse(secondChar);
                        //char third = char.Parse(thirdChar);

                        Console.WriteLine($"{command}: {firstNum} {secondNum} {thirdNum}");

                    }
                    //else
                    //{
                    //    Console.WriteLine("Valid message not found!");
                    //}
                }


            }

        }
    }
}
