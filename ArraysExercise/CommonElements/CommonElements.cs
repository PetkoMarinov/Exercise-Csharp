using System;
using System.Linq;

namespace CommonElements
{
    class CommonElements
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();
            string[] result = new string[firstArr.Length];

            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int k = 0; k < firstArr.Length; k++)
                {
                    if (secondArr[i] == firstArr[k])
                    {
                        result[i] = secondArr[i];
                    }
                }
            }
            result = result.Where(str => !string.IsNullOrWhiteSpace(str)).ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
