using System;
using System.Linq;

namespace VendingMachine
{
    class VendingMachine
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            double sum = 0;
            string[] possibleCoins = { "0.1", "0.2", "0.5", "1", "2" };

            while (input != "start")
            {
                if (possibleCoins.Contains(input))
                {
                    sum += double.Parse(input);
                    input = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                    input = Console.ReadLine().ToLower();
                }
            }

            while (input != "end")
            {
                input = Console.ReadLine().ToLower();

                if (input == "end")
                {
                    break;
                }

                if (input == "nuts" || input == "crisps" || input == "coke" ||
                    input == "soda" || input == "water")
                {
                    if (input == "nuts" && sum >= 2)
                    {
                        Console.WriteLine($"Purchased {input}");
                        sum -= 2;
                    }
                    else if (input == "crisps" && sum >= 1.5)
                    {
                        Console.WriteLine($"Purchased {input}");
                        sum -= 1.5;
                    }
                    else if (input == "coke" && sum >= 1)
                    {
                        Console.WriteLine($"Purchased {input}");
                        sum -= 1;
                    }
                    else if (input == "soda" && sum >= 0.8)
                    {
                        Console.WriteLine($"Purchased {input}");
                        sum -= 0.8;
                    }
                    else if (input == "water" && sum >= 0.7)
                    {
                        Console.WriteLine($"Purchased {input}");
                        sum -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }

            if (sum >= 0)
            {
                Console.WriteLine($"Change: {sum:f2}");
            }
        }
    }
}
