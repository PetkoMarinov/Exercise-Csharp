using System;
using System.Linq;

namespace TopIntegers2
{
    class TopIntegers2
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int[] temp = new int[arr.Length - 1 - i];
                for (int k = 0; k < temp.Length; k++)
                {
                    temp[k] = arr[k + 1 + i];
                }

                if (arr[i] > temp.Max())
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.Write(arr[arr.Length - 1]);
        }
    }
}
