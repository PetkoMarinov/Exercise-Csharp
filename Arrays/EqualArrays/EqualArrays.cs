using System;
using System.Linq;

namespace EqualArrays
{
    class EqualArrays
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool identical = true;

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    Console.WriteLine("Arrays are not identical. " +
                        $"Found difference at {i} index");
                    identical = false;
                    break;
                }
                sum += firstArr[i];
            }

            if (identical==true)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
