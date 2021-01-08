using System;

namespace _10.LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());

            if (char.IsLower(firstChar))
            {
                Console.WriteLine("lower-case");
            }
            else if (char.IsUpper(firstChar))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
