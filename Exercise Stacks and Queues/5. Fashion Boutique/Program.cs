using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int []clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothes);
            int racks = 1;
            
            int currentCapacity = rackCapacity;

            while (stack.Count>0)
            {
                int value = stack.Pop();
                if ((currentCapacity-value)>=0)
                {
                    currentCapacity -= value;
                }
                else
                {
                    racks += 1;
                    currentCapacity = rackCapacity;
                    currentCapacity -= value;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
