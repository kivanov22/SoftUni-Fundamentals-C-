using System;

namespace _9.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

           
            GetMaxValue(type, input1, input2);




        }

        private static void GetMaxValue(string type, string input1, string input2)
            {
            if (type=="int")
            {
                int input1AsInt = int.Parse(input1);
                int intpu2AsInt = int.Parse(input2);
                Console.WriteLine(Math.Max(input1AsInt,intpu2AsInt));
            }
            else if (type=="char")
            {
                char input1AsChar = char.Parse(input1);
                char input2AsChar = char.Parse(input2);
                if (input1AsChar.CompareTo(input2AsChar)>0)
                {
                    Console.WriteLine(input1AsChar);
                }
                else
                {
                    Console.WriteLine(input2AsChar);
                }

                //char input1AsChar = char.Parse(input1);
                //char input2AsChar = char.Parse(input2);
                //Console.WriteLine(Math.Max(input1AsChar,input2AsChar));
            }
            else if (type=="string")
            {
                if (input1.CompareTo(input2)>0)
                {
                    Console.WriteLine(input1);
                }
                else
                {
                    Console.WriteLine(input2);
                }
            }
            }

    }
}
//if (formatType == "int")
//{
//    num1 = int.Parse(input1);
//    num2 = int.Parse(input2);
//}
//else if (formatType == "string" || formatType == "char")
//{
//    num1 = input1[0];
//    num2 = input2[0];
//}