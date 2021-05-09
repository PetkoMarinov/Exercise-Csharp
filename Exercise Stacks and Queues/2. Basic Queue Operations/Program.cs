using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int toDequeue = int.Parse(input[1]);
            int toLookFor = int.Parse(input[2]);

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(numbers);

            for (int i = 0; i < toDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int length = queue.Count;
                bool found = false;
                int smallest = int.MaxValue;

                for (int i = 0; i < length; i++)
                {
                    int chekedNumber = queue.Dequeue();

                    if (chekedNumber == toLookFor)
                    {
                        Console.WriteLine("true");
                        found = true; break;
                    }

                    if (smallest > chekedNumber)
                    {
                        smallest = chekedNumber;
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
