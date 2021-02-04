using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int size = arr.Length;

            if (size == 0)
            {
                Console.WriteLine($"{arr[0]} is already condensed to number");
            }

            while (size > 0)
            {
                int[] condensed = new int[size - 1];
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = arr[i] + arr[i + 1];
                }
                condensed.CopyTo(arr, 0);
                size--;
            }
            Console.WriteLine(arr[0]);
        }
    }
}
