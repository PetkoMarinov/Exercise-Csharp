using System;
using System.Text;

namespace Login
{
    class Login
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string input = Console.ReadLine();
            StringBuilder pass = new StringBuilder();

            for (int i = 0; i < username.Length; i++)
            {
                pass.Append(username[username.Length - 1 - i]);
            }

            byte counter = 1;
            while (input != pass.ToString())
            {
                if (counter==4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
                counter++;
            }

            if (input == pass.ToString())
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
