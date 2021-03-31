using System;

namespace The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Decode")
            {
                string[] data = input.Split('|');
                string command = data[0];

                if (command == "Move")
                {
                    int count = int.Parse(data[1]);

                    string characters = message.Substring(0, count);
                    message = message.Substring(count) + characters;
                }

                else if (command == "Insert")
                {
                    int index = int.Parse(data[1]);
                        message = message.Insert(index, data[2]);
                }

                else if (command == "ChangeAll")
                {
                    string oldValue = data[1];
                    string newValue = data[2];
                    message = message.Replace(oldValue, newValue);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
