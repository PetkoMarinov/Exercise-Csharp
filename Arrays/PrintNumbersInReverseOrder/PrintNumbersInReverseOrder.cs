using System;
using System.Linq;

namespace PrintNumbersInReverseOrder
{
    class PrintNumbersInReverseOrder
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] reversed = new int[input];

            for (int i = 0; i < input; i++)
            {
                reversed[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(' ', reversed.Reverse()).ToArray());
        }
    }
}
