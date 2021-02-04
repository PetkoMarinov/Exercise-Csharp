using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballNumber = int.Parse(Console.ReadLine());
            BigInteger highestValue = 0;
            int highestSnow = 0;
            int highestTime = 0;
            int highestQuality = 0;

            for (int i = 0; i < snowballNumber; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = 
                    BigInteger.Pow((snowballSnow / snowballTime),snowballQuality);

                if (highestValue < snowballValue)
                {
                    highestValue = snowballValue;
                    highestSnow = snowballSnow;
                    highestTime = snowballTime;
                    highestQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{highestSnow} : { highestTime} = { highestValue}" +
                $" ({ highestQuality})");
        }
    }
}
