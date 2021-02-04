using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int tempPower = power;
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int counter = 0;

            while (tempPower >= distance)
            {
                tempPower -= distance;
                counter++;
                if (tempPower == power * 0.5 &&exhaustionFactor>0)
                {
                    tempPower /= exhaustionFactor;
                }
            }
            Console.WriteLine(tempPower);
            Console.WriteLine(counter);
        }
    }
}
