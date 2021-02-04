using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    class EvenAndOddSubtraction
    {
        static void Main(string[] args)
        {
            //Write a program that calculates the difference between the sum 
            //of the even and the sum of the odd numbers in an array.

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
                else
                {
                    sum -= Math.Abs(arr[i]);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
