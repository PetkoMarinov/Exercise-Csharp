using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    class Program
    {
        class City
        {
            public string Name { get; set; }
            public int Population { get; set; }
            public int Gold { get; set; }

            public City() { }
        }

        static void Main(string[] args)
        {
            string sailInput = Console.ReadLine();
            List<City> towns = new List<City>();

            while (sailInput != "Sail")
            {
                string[] cityInfo = sailInput.Split("||");

                City city = new City();
                city.Name = cityInfo[0];
                city.Population = int.Parse(cityInfo[1]);
                city.Gold = int.Parse(cityInfo[2]);

                if (towns.Exists(x => x.Name == city.Name))
                {
                    towns.Find(x => x.Name == city.Name).Population += city.Population;
                    towns.Find(x => x.Name == city.Name).Gold += city.Gold;
                }
                else
                {
                    towns.Add(city);
                }

                sailInput = Console.ReadLine();
            }

            string eventsInput = Console.ReadLine();

            while (eventsInput != "End")
            {
                string[] eventsInfo = eventsInput.Split("=>");
                string command = eventsInfo[0];

                if (command == "Plunder")
                {
                    string chosenCity = eventsInfo[1];
                    int peopleKilled = int.Parse(eventsInfo[2]);
                    int goldStollen = int.Parse(eventsInfo[3]);

                    towns.Find(x => x.Name == chosenCity).Population -= peopleKilled;
                    towns.Find(x => x.Name == chosenCity).Gold -= goldStollen;

                    Console.WriteLine($"{chosenCity} plundered! {goldStollen} gold stolen, " +
                        $"{peopleKilled} citizens killed.");

                    City cityPlundered = towns.Find(x => x.Name == chosenCity);

                    if (cityPlundered.Population == 0 || cityPlundered.Gold == 0)
                    {
                        towns.Remove(cityPlundered);
                        Console.WriteLine($"{cityPlundered.Name} has been wiped off the map!");
                    }
                }
                else if (command == "Prosper")
                {
                    string prosperTown = eventsInfo[1];
                    int goldAdded = int.Parse(eventsInfo[2]);

                    if (goldAdded < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        towns.Find(x => x.Name == prosperTown).Gold += goldAdded;
                        Console.WriteLine($"{goldAdded} gold added to the city treasury." +
                            $" {prosperTown} now has " +
                            $"{towns.Find(x => x.Name == prosperTown).Gold} gold.");
                    }
                }

                eventsInput = Console.ReadLine();
            }

            if (towns.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} " +
                    $"wealthy settlements to go to:");

                foreach (var town in towns.OrderByDescending(x => x.Gold).ThenBy(x => x.Name))
                {
                    Console.WriteLine($"{ town.Name} -> Population: {town.Population} " +
                        $"citizens, Gold: {town.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been " +
                    $"plundered and destroyed!");
            }
        }
    }
}
