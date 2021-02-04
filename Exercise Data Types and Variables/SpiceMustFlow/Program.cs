using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int days = 0;
            int spice = 0;

            while (yield>=100)
            {
                days++;
                spice += yield;
                spice -= 26;
                yield -= 10;

                if (yield<100)
                {
                    spice -= 26;
                }
            }
            Console.WriteLine(days);
            Console.WriteLine(spice);
        }
    }
}
