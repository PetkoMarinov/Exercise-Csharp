using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] specialNum = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (numbers.Contains(specialNum[0]))
            {
                int specialNumIndex = numbers.IndexOf(specialNum[0]);
                int startIndex = specialNumIndex - specialNum[1];
                int endIndex = specialNumIndex + specialNum[1];

                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                if (endIndex > numbers.Count - 1)
                {
                    endIndex = numbers.Count - 1;
                }

                for (int i = startIndex; i <= endIndex; i++)
                {
                    numbers.RemoveAt(startIndex);
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}