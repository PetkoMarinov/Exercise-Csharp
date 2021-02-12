using System;

namespace Center_Point
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestPoint(x1, y1, x2, y2);
        }

        static void PrintClosestPoint(double x1, double y1, double x2, double y2)
        {
            double diagonalOne = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double diagonalTwo = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (diagonalOne <= diagonalTwo)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
