using System;
using System.Linq;

namespace TopIntegers
{
    class TopIntegers
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] topIntegers = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                bool isTop = true;
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] <= arr[k])
                    {
                        isTop = false;
                        break;
                    }
                }
                if (isTop)
                {
                    topIntegers[i] = (arr[i]).ToString();
                }
            }

            topIntegers = topIntegers.Where(topIntegers =>
                !string.IsNullOrWhiteSpace(topIntegers)).ToArray();
            Console.WriteLine(string.Join(" ", topIntegers));
        }
    }
}
