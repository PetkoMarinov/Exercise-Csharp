using System;
using System.Linq;

namespace _6._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n];

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                double fuel = double.Parse(carInfo[1]);
                double fuelConsumption = double.Parse(carInfo[2]);

                cars[i] = new Car(model,fuel,fuelConsumption);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="End")
                {
                    foreach (var car in cars)
                    {
                        Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
                    }
                    break;
                }

                string modelToDrive = input.Split(' ')[1];
                double kmToDrive = double.Parse(input.Split(' ')[2]);
                cars.Where(c => c.Model == modelToDrive).ToList().ForEach(c => c.Drive(kmToDrive));
            }
        }
    }
}
