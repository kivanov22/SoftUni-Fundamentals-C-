using System;
using System.Linq;
using System.Text;

namespace _5.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            string firstNumber = (Console.ReadLine().TrimStart('0'));//removes 0 in begining when taking string 0002 for example
            int secondNumber = int.Parse(Console.ReadLine());

            int temp = 0;

            if (secondNumber==0||firstNumber=="")//check if number is valid if not stop and print 0
            {
                Console.WriteLine(0);
                return;
            }
            foreach (char number in firstNumber.Reverse())//so we start from last number
            {
                int digit = int.Parse(number.ToString());//char -> to string -> number
                int multiply = digit * secondNumber + temp;

                int lastElement = multiply % 10;//we taking the excess 
                temp = multiply / 10;

                sb.Insert(0, lastElement);//we insert on 0 index the element
            }
            if (temp > 0)//if we got excess 
            {
                sb.Insert(0, temp);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
