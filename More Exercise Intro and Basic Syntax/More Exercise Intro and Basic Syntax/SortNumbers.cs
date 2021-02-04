using System;
using System.Linq;

namespace More_Exercise_Intro_and_Basic_Syntax
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            for (int i = numbers.Length-1; i >=0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
