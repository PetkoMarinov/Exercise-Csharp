using System;

namespace Exercise_Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4];
            for (int i = 0; i < 4; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine( ((numbers[0] + numbers[1]) / numbers[2]) * numbers[3]);
        }
    }
}
