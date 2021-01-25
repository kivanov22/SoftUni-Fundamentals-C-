using System;

namespace _4.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isTrue= PrintLengthCharacters(password) &&
                         PrintLettersNumbers(password) &&
                         PrintTwoDigits(password);

            if (isTrue)// if true
            {
                Console.WriteLine("Password is valid");
            }
            //if false
            else
            {
                if (!PrintLengthCharacters(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                //if because if upper if is correct we dont check below cases
                if (!PrintLettersNumbers(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!PrintTwoDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
            
        }

        private static bool PrintTwoDigits(string password)
        {
            int count = 0;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            if (count>=2)
            {
                return true;//when we use return no need of else
            }
            return false;
        }

        private static bool PrintLettersNumbers(string password)
        {
            foreach  (char c in password)
            {
                if (!char.IsLetterOrDigit(c))//check if letter or digit
                {
                    return false;
                }
            }
            return true;
        }

        private static bool PrintLengthCharacters(string password)
        {
            if (password.Length>=6 && password.Length<=10)
            {
                bool isTrue = true;
                return isTrue;
            }
            return false;
        }
    }
}
