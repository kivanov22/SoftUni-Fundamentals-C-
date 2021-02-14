using System;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes_two
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternBarcode = @"@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+";

            Regex validBarcode = new Regex(patternBarcode);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = validBarcode.Match(input);

                if (match.Success)
                {
                    string compare = match.Value;
                    string temp = "";

                    for (int j = 0; j < compare.Length; j++)
                    {
                        char current = compare[j];

                        if (char.IsDigit(current))
                        {
                            temp += current;
                        }
                    }
                    if (temp=="")
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {temp}");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
                
            }





        }
    }
}
