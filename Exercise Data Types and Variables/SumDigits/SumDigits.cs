using System;

namespace SumDigits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int length = number.ToString().Length;
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
