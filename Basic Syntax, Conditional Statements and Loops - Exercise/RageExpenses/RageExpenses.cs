using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            float total = 0;

            for (int i = gamesLost; i > 0; i--)
            {
                if (i % 12 == 0)
                {
                    total += headsetPrice + mousePrice + keyboardPrice + displayPrice;
                }
                else if (i % 6 == 0)
                {
                    total += headsetPrice + mousePrice + keyboardPrice;
                }
                else if (i % 3 == 0)
                {
                    total += mousePrice;
                }
                else if (i % 2 == 0)
                {
                    total += headsetPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
