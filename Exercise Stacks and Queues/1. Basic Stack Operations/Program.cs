using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int toPop = int.Parse(input[1]);
            int toLookFor = int.Parse(input[2]);

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);
            int length = stack.Count;

            for (int i = 0; i < toPop; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int smallest = int.MaxValue;
                bool found = false;
                int lookFor = 0;
                length = stack.Count;

                for (int i = 0; i < length; i++)
                {
                    lookFor = stack.Pop();

                    if (lookFor == toLookFor)
                    {
                        Console.WriteLine("true");
                        found = true; break;
                    }

                    if (lookFor < smallest)
                    {
                        smallest = lookFor;
                    }
                }
                if (!found)
                {
                    Console.WriteLine(smallest);
                }
            }
        }
    }
}
