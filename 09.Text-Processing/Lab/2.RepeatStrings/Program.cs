using System;
using System.Text;

namespace _2.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);//array of strings

            string result = "";
            //can be done with string builder too 
            foreach (string word in words)
            {
                int count = word.Length;//take every word lenght


                for (int i = 0; i < count; i++)//for loop till lenght
                {
                    result += word;
                    //result.append(word);
                }
            }
            Console.WriteLine(result);



            

        }
    }
}
