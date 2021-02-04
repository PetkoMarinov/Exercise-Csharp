using System;

namespace SumOfChars
{
    class SumOfChars
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sum = 0;

            while (lines > 0)
            {
                char ch = char.Parse(Console.ReadLine());
                sum += ch;
                lines--;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
