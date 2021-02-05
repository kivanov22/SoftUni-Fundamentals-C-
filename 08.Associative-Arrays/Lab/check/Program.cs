using System;

namespace check
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());


                for (int i = 1; i <= n; i++)                        //проверка на i и добавяне на 1 към резултата, така докато стане 10;
                {
                
                    string something = new string('*', i);      //заменя "i" със символа звезда "*" ;
                    Console.WriteLine(something);
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(something);
                }//отпечатва броя на "*" на нов ред ;
                }
                











        }
    }
}
