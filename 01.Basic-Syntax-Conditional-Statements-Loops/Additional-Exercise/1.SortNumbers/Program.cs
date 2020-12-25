using System;

namespace _1.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number1 = int.Parse(Console.ReadLine());
            //int number2 = int.Parse(Console.ReadLine());
            //int number3 = int.Parse(Console.ReadLine());

            int[] intArray = new int[3];// със това създаваш 3 цифрен array

            for (int i = 0; i < intArray.Length; i++) //тук казваш цъкала да върти колкото е голям arraya
            {
                intArray[i] = int.Parse(Console.ReadLine());// приемаш новата цифра от конзолата на всеки цъкъл(трите числа) и издлиза
            }
            Array.Sort(intArray);// сортира ги по големина ({4}{1}{3}={1}{3}{4})
            Array.Reverse(intArray);// обръща вече сортирания array иначе е от най малкото към най голямото {1}{3}{4}={4}{3}{1}

            for (int x = 0; x < intArray.Length; x++)
            {
                Console.WriteLine(intArray[x]);// и тук вече си ги разпечатваш сортирани = 4 3 1
            }
        }
    }
}
//Another Option for this task

//int num1 = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
//int num3 = int.Parse(Console.ReadLine());
//int largest = Math.Max(Math.Max(num1, num2), num3);
//int smallest = Math.Min(Math.Min(num1, num2), num3);
//int middle = (num1 + num2 + num3) - (largest + smallest);
//Console.WriteLine(largest);
//Console.WriteLine(middle);
//Console.WriteLine(smallest);