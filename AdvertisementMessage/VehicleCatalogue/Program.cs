using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    public class Vehicle
    {
        public Vehicle()
        {

        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Colour { get; set; }

        public int HorsePower { get; set; }

        public override string ToString()
        {
            string vehicleStr = $"Type: {(this.Type == "car" ? "Car" : "Truck")}\n" +
                                $"Model: {this.Model}\n" +
                                $"Color: {this.Colour}\n" +
                                $"Horsepower: {this.HorsePower}";

            return vehicleStr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Vehicle> motorVehicles = new List<Vehicle>();

            while (input != "End")
            {
                Vehicle vehicle = new Vehicle();

                vehicle.Type = input.Split()[0];
                vehicle.Model = input.Split()[1];
                vehicle.Colour = input.Split()[2];
                vehicle.HorsePower = int.Parse(input.Split()[3]);

                motorVehicles.Add(vehicle);
                input = Console.ReadLine();
            }

            string modelsInput = Console.ReadLine();

            while (modelsInput != "Close the Catalogue")
            {
                List<Vehicle> output = motorVehicles
                    .Where(x => x.Model == modelsInput).ToList();
                Console.WriteLine(string.Join("\n", output));

                modelsInput = Console.ReadLine();
            }

            List<Vehicle> cars = motorVehicles.Where(x => x.Type == "car").ToList();
            List<Vehicle> trucks = motorVehicles.Where(x => x.Type == "truck").ToList();

            int carsHpSum = 0;
            int trucksHpSum = 0;

            foreach (var car in cars)
            {
                carsHpSum += car.HorsePower;
            }

            foreach (var truck in trucks)
            {
                trucksHpSum += truck.HorsePower;
            }

            double carsAverage = (double)carsHpSum / cars.Count;
            double trucksAverage = (double)trucksHpSum / trucks.Count;

            if (cars.Count != 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carsAverage:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (trucks.Count != 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucksAverage:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }

        }
    }
}
