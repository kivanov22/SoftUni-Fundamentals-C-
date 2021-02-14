using System;
using System.Text.RegularExpressions;

namespace _2.Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string pattern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
            //@#FreshFisH@#, @###Brea0D@###, @##Che46sE@##, @##Che46sE@###
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);//Match is for single MatchCollection for multiple

                if (match.Success)
                {
                    string compare = match.Value;//current Match 
                    string temporary = "";

                    for (int j = 0; j < compare.Length; j++)
                    {
                        if (char.IsDigit(compare[j]))
                        {
                            temporary += compare[j];
                            
                        }
                        
                    }

                    if (temporary== "")
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {temporary}");
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
