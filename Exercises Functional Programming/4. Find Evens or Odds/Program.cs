using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = input[0];
            int end = input[1];

            int[] numbers = Enumerable.Range(start, end).ToArray();
            string command = Console.ReadLine();

            Predicate<int> predicate = x => true;

            switch (command)
            {
                case "odd": predicate = x => x % 2 != 0; break;
                case "even": predicate = x => x % 2 == 0; break;
            }

            numbers = numbers.Where(x => predicate(x)).ToArray();
            Console.Write(string.Join(" ",numbers));
        }
    }
}
