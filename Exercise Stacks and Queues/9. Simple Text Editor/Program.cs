using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();

            int lines = int.Parse(Console.ReadLine());
            Stack<string[]> listOfExecutedCommands = new Stack<string[]>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int command = int.Parse(input[0]);

                switch (command)
                {
                    case 1:
                        string appendString = input[1];

                        for (int k = 0; k < appendString.Length; k++)
                        {
                            stack.Push(appendString[k]);
                        }
                        listOfExecutedCommands.Push(input); break;

                    case 2:
                        int eraseCount = int.Parse(input[1]);
                        for (int j = 0; j < eraseCount; j++)
                        {
                            stack.Pop();
                        }
                        listOfExecutedCommands.Push(input); break;

                    case 3:
                        int index = int.Parse(input[1]) - 1;
                        char[] array = stack.ToArray();
                        Array.Reverse(array);
                        Console.WriteLine(array[index]);
                        break;

                    default:
                        int undoCommand = int.Parse(listOfExecutedCommands.Peek()[0]);
                        string undoText = listOfExecutedCommands.Peek()[1];
                        listOfExecutedCommands.Pop();

                        if (undoCommand == 1)
                        {
                            for (int p = 0; p < undoText.Length; p++)
                            {
                                stack.Pop();
                            }
                        }
                        else
                        {
                            for (int p = 0; p < int.Parse(undoText); p++)
                            {
                                string add = listOfExecutedCommands.Peek()[1];
                                stack.Push(add[p]);
                            }
                        }
                        break;
                }
            }
        }
    }
}
