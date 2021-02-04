using System;

namespace ArraysExercise
{
    class Train
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] train = new int[wagons];

            for (int i = 0; i < wagons; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                sum += train[i];
            }
            Console.WriteLine(string.Join(" ",train));
            Console.WriteLine(sum);
        }
    }
}
