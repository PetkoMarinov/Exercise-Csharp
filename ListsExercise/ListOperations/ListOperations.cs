using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class ListOperations
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                string[] command = input.Split();
                if (command[0] == "add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else if (command[0] == "insert")
                {
                    if (int.Parse(command[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    }
                }
                else if (command[0] == "remove")
                {
                    if (int.Parse(command[1]) > numbers.Count - 1 ||
                        int.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(int.Parse(command[1]));
                    }
                }
                else if (command[1] == "left")
                {
                    for (int i = 0; i < int.Parse(command[2]); i++)
                    {
                        int temp = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(temp);
                    }
                }
                else if (command[1] == "right")
                {
                    for (int i = 0; i < int.Parse(command[2]); i++)
                    {
                        int temp = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, temp);
                    }
                }
                input = Console.ReadLine().ToLower();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}