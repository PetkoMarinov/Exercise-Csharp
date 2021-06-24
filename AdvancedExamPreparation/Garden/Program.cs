using System;
using System.Collections.Generic;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine()[0].ToString());

            int[,] garden = new int[side, side];

            string input = Console.ReadLine();

            List<int[]> coordinates = new List<int[]>();

            while (input != "Bloom Bloom Plow")
            {
                int[] arr = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                if (arr[0] < 0 || arr[0] > side || arr[1] < 0 || arr[1] > side)
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                else
                {
                    coordinates.Add(arr);
                }

                input = Console.ReadLine();
            }

            foreach (var indexes in coordinates)
            {
                int row = indexes[0];
                int col = indexes[1];

                for (int i = 0; i < side; i++)
                {
                    garden[row, i] += 1;
                }

                for (int i = 0; i < side; i++)
                {
                    garden[i, col] += 1;
                }

                garden[row, col] -= 1;
            }

            PrintGarden(garden);
        }

        private static void PrintGarden(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} "); 
                }
                Console.WriteLine();
            }
        }
    }
}
