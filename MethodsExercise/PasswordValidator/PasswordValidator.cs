using System;

namespace PasswordValidator
{
    class PasswordValidator
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isTrue = true;
            bool temp = false;

            temp = CharactersNumberCheck(password);
            if (temp == false)
            {
                isTrue = false;
            }
            temp = CharactersTypeCheck(password);
            if (temp == false)
            {
                isTrue = false;
            }
            temp = CheckDigitsNumber(password);
            if (temp == false)
            {
                isTrue = false;
            }

            if (isTrue)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CharactersNumberCheck(string input)
        {
            if (input.Length < 6 || input.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            return true;
        }

        static bool CharactersTypeCheck(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetterOrDigit(input[i]))
                {
                    Console.WriteLine("Password must consist only " +
                                   "of letters and digits");
                    return false;
                }
            }
            return true;
        }

        static bool CheckDigitsNumber(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsNumber(input[i]))
                {
                    counter++;
                }
            }

            if (counter < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            return true;
        }
    }
}
