using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                int num = queue.Dequeue();
                if (num % 2 == 0)
                {
                    queue.Enqueue(num);
                }
            }

            Console.WriteLine(string.Join(", ",queue));
        }
    }
}
