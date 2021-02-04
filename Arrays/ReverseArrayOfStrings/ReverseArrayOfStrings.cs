using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split()
                .Reverse()
                .ToArray();

            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
