using System;

namespace StrongNumber
{
    class StrongNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            int sum = 0;
            int temp = number;

            for (int i = 0; i < number.ToString().Length; i++)
            {
                int num = temp % 10;
                for (int k = 2; k <= num; k++)
                {
                    factorial *= k;
                }
                sum += factorial;
                factorial = 1;
                temp /= 10;
            }

            if (number == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
