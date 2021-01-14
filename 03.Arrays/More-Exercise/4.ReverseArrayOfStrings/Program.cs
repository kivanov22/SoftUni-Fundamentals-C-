using System;
using System.Linq;

namespace _4.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(' ',Console.ReadLine()
                .Split().Reverse()));

            //v konzola za izpisvane slaga string join za da dobavi space, sled tova prochita ot konzolata
            //sled tova gi razdelq i gi obrushta s reverse.
        }
    }
}
