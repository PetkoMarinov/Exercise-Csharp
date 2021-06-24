using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._The_Fight_for_Gondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());
            Queue<int> plates = new Queue<int>(Console.ReadLine()
                .Split(' ').Select(int.Parse));

            Stack<int> orcs = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            for (int i = 1; i <= waves; i++)
            {
                if (i % 3 == 0)
                {
                    plates.Enqueue(int.Parse(Console.ReadLine()));
                }

                while (orcs.Count > 0 && plates.Count > 0)
                {
                    int orcPower = orcs.Pop();
                    int humanPower = plates.Dequeue();

                    if (orcPower > humanPower)
                    {
                        orcs.Push(orcPower - humanPower);
                    }
                    else if (orcPower < humanPower)
                    {
                        plates.Enqueue(humanPower - orcPower);

                        for (int k = 0; k < plates.Count - 1; k++)
                        {
                            plates.Enqueue(plates.Dequeue());
                        }
                    }
                }

                if (plates.Count <= 0 || i == waves)
                {
                    break;
                }

                orcs = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            }

            if (plates.Count > 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
            }
        }
    }
}
