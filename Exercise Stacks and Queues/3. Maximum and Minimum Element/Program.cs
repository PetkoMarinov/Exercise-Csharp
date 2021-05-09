using System;
using System.Collections.Generic;

namespace _3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int lines = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < lines; i++)
            {
                int command = int.Parse(input[0]);

                if (command==1)
                {
                    int number = int.Parse(input[1]);
                    stack.Push(number);
                }
                else if (command==2)
                {
                    stack.Pop();
                }
                else 
                {
                    int max = int.MinValue;
                    int min = int.MaxValue;
                    int length = stack.Count;

                    if (length!=0)
                    {
                        Stack<int> temp = new Stack<int>(stack);
                        for (int k = 0; k < length; k++)
                        {
                            int checkedNumber = temp.Pop();
                            if (max < checkedNumber)
                            {
                                max = checkedNumber;
                            }

                            if (min > checkedNumber)
                            {
                                min = checkedNumber;
                            }
                        }

                        if (command==3)
                        {
                            Console.WriteLine(max);
                        }
                        else
                        {
                            Console.WriteLine(min);
                        }
                    }
                }

                input = Console.ReadLine().Split();
            }

            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
        }
    }
}
