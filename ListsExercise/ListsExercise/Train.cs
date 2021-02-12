using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercise
{
    class Train
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "End".ToLower())
            {
                if (command.ToLower().Contains("add"))
                {
                    wagons.Add(int.Parse(command.Substring(command.IndexOf(" "))));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (int.Parse(command) > capacity - wagons[i])
                        {
                            continue;
                        }
                        else
                        {
                            wagons[i] = wagons[i] + int.Parse(command);
                            i -= 1;
                            break;
                        }
                    }

                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
