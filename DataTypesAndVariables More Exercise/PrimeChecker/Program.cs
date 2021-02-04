using System;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                bool prime = true;
                for (int divider = 2; divider < i; divider++)
                {
                    if (i % divider == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, prime.ToString().ToLower());
            }
        }
    }
}
