using System;
using System.Linq;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double average = sequence.Average();

            int[] topFive = sequence
                .Where(n => n > average)
                .OrderByDescending(n => n)
                .Take(5)
                .ToArray();

            if (topFive.Length == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", topFive));
            }
        }
    }
}
