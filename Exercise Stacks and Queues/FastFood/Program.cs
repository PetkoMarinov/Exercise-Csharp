using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalQuantity = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(input);
            int biggest = int.MinValue;

            foreach (var order in orders)
            {
                if (biggest < order)
                {
                    biggest = order;
                }
            }

            Console.WriteLine(biggest);

            int ordersPieces = orders.Count;

            for (int i = 0; i < ordersPieces; i++)
            {
                int singleOrderQty = orders.Peek();
                if (totalQuantity >= singleOrderQty)
                {
                    singleOrderQty = orders.Dequeue();
                    totalQuantity -= singleOrderQty;
                }

            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine("Orders left: " + string.Join(" ", orders));
            }


        }
    }
}
