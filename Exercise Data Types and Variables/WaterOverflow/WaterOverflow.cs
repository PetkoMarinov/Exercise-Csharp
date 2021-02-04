using System;

namespace WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int waterInput = int.Parse(Console.ReadLine());
            int capacity = 255;

            for (int i = 0; i < waterInput; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                if ((capacity-quantity)>=0)
                {
                    capacity -= quantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(255-capacity);
        }
    }
}
