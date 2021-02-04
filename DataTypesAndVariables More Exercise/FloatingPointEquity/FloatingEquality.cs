using System;
using System.Linq;

public class EntryPoint
{
    public static void Main()
    {
        float eps = 0.000001f;
        double n1 = double.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());
        bool isEqual = Math.Abs(n1 - n2) < eps;

        if (isEqual)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}