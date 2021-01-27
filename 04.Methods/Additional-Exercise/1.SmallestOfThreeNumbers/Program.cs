using System;

namespace _1.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	If the data type is int, multiply the number by 2.
            //•	If the data type is real, multiply the number by 1.5 and format it to the second decimal point.
            //•	If the data type is string, surround the input with "$".
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            PrintOutput(input1,input2);


        }

        private static void PrintOutput(string input1 , string input2)
        {
            if (input1=="string")
            {
                Console.WriteLine($"${input2}$");
            }
            else if (input1=="int")
            {
                int input2AsNumber = int.Parse(input2);
                int sum = 0;
                sum = input2AsNumber * 2;
                Console.WriteLine(sum);
            }
            else if (input1=="real")
            {
                double input2AsNumber = double.Parse(input2);
                double sum = 0;
                sum = input2AsNumber * 1.5;
                Console.WriteLine($"{sum:f2}");
            }
        }
    }
}
