using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string inputCommand = Console.ReadLine().ToLower();

            while (inputCommand != "3:1")
            {
                string[] command = inputCommand.Split(" ");
                int startIndex = int.Parse(command[1]);
                int endIndex = int.Parse(command[2]);

                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                if (startIndex > input.Count - 1)
                {
                    startIndex = input.Count - 1;
                }

                if (command[0] == "merge")
                {
                    if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }

                    for (int i = 0; i < (endIndex - startIndex); i++)
                    {
                        input[startIndex] += input[startIndex + 1];
                        input.RemoveAt(startIndex + 1);
                    }
                }
                else if (command[0] == "divide")
                {
                    int newIndexLength = input[startIndex].Length % int.Parse(command[2]);
                    string temp = input[startIndex];

                    for (int i = 0; i < newIndexLength; i++)
                    {
                        if (itemlength % int.Parse(command[2]) == 0)
                        {
                            input[startIndex] += input[startIndex + 1];
                            input.RemoveAt(startIndex + 1);
                        }
                    }
                }
                inputCommand = Console.ReadLine().ToLower();
            }
        }
    }
}
