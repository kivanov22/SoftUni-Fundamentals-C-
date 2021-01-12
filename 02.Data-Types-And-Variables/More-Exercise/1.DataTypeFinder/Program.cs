using System;

namespace _1.DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command !="END")
            {
                bool intTryParseSuccess = int.TryParse(command, out int intValue);
                bool doubleTryParseSuccess = double.TryParse(command, out double doubleValue);
                bool charTryParseSuccess = char.TryParse(command, out char charValue);
                bool boolTryParseSuccess = bool.TryParse(command, out bool boolValue);


                if (intTryParseSuccess)
                {
                    Console.WriteLine($"{command} is integer type");
                }
                else if (doubleTryParseSuccess)
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if (boolTryParseSuccess)
                {
                    Console.WriteLine($"{command} is boolean type");
                }
                else if (charTryParseSuccess)
                {
                    Console.WriteLine($"{command} is character type");
                }
                else
                {
                    Console.WriteLine($"{command} is string type");
                }

                command = Console.ReadLine();



            }
        }
    }
}
