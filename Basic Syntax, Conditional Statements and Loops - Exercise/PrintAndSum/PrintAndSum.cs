using System;

namespace PrintAndSum
{
    class PrintAndSum
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                if (i<end)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.WriteLine(i);
                }
                sum += i;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
