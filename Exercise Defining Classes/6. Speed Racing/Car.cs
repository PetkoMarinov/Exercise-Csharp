using System;

namespace _6._Speed_Racing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuel, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuel;
            this.FuelConsumption = fuelConsumption;
            this.TravelledDistance = 0;
        }

        public void Drive(double distance)
        {
            double fuelNeeded = distance * FuelConsumption;
            if (FuelAmount >= fuelNeeded)
            {
                FuelAmount -= fuelNeeded;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }

    }
}
