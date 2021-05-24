using System;
using System.Collections.Generic;

namespace _7._Truck_Tour
{
    class Program
    {
        class Pump
        {
            public int Petrol { get; set; }
            public int Distance { get; set; }

            public Pump(int petrol, int distance)
            {
                this.Petrol = petrol;
                this.Distance = distance;
            }

        }

        static void Main(string[] args)
        {
            int pumps = int.Parse(Console.ReadLine());
            Queue<Pump> queue = new Queue<Pump>(pumps);

            for (int i = 0; i < pumps; i++)
            {
                string[] data = Console.ReadLine().Split();
                int petrol = int.Parse(data[0]);
                int distance = int.Parse(data[1]);

                Pump pump = new Pump(petrol, distance);
                queue.Enqueue(pump);
            }


            int index = 0;

            while (true)
            {
                int petrolInTank = 0;

                foreach (Pump pump in queue)
                {
                    int nextPumpDistance = queue.Peek().Distance;
                    int currentPumpPetrol = queue.Peek().Petrol;
                    petrolInTank += (currentPumpPetrol - nextPumpDistance);

                    if (petrolInTank < 0)
                    {
                        queue.Enqueue(queue.Dequeue());
                        index++;
                        break;
                    }
                }

                if (petrolInTank>=0)
                {
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}