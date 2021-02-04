using System;

namespace ArrayRotation
{
    class ArrayRotation
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string temp = input[0];
                for (int k = 0; k < input.Length - 1; k++)
                {
                    input[k] = input[k + 1];
                }
                input[input.Length - 1] = temp;
            }
            Console.WriteLine($"{string.Join(" ", input)}");
        }
    }
}
