using System;
using System.Linq;

namespace EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool equal = true;

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                if (arr.Length == 1)
                {
                    Console.WriteLine(0);
                    break;
                }
                else if (arr.Length == 2)
                {
                    Console.WriteLine("no");
                    break;
                }
                else
                {
                    for (int k = 0; k < i; k++)
                    {
                        leftSum += arr[k];
                    }

                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        rightSum += arr[j];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    equal = true;
                    break;
                }
                else
                {
                    equal = false;
                }

            }

            if (!equal)
            {
                Console.WriteLine("no");
            }
        }
    }
}
