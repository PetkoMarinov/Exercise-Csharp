using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string biggestKeg = string.Empty;
            double volume = 0;

            while (lines > 0)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double biggestVolume = Math.PI * radius * radius * height;
                lines--;

                if (volume < biggestVolume)
                {
                    volume = biggestVolume;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
