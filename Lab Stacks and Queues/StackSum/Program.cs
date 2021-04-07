using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);

            string input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                string command = input.Split()[0];
                if (command == "add")
                {
                    string first = input.Split()[1];
                    string second = input.Split()[2];
                    stack.Push(int.Parse(first));
                    stack.Push(int.Parse(second));
                }
                else if (command == "remove")
                {
                    int removedNums = int.Parse(input.Split()[1]);

                    if (stack.Count >= removedNums)
                    {
                        for (int i = 0; i < removedNums; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
