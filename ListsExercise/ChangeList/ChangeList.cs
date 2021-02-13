using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                int length = numbers.Count;
                string[] temp = command.Split();

                if (temp[0] == "delete")
                {
                    numbers.RemoveAll(n => n == int.Parse(temp[1]));
                }
                else if (temp[0] == "insert")
                {
                    numbers.Insert(int.Parse(temp[2]), int.Parse(temp[1]));
                }

                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
