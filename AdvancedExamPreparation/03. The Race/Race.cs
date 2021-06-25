using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;

        public Race(string name, int capacity)
        {
            this.data = new List<Racer>();
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get => this.data.Count; }

        public void Add(Racer racer)
        {
            if (Capacity > Count)
            {
                data.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            bool racerExists = data.Exists(r => r.Name == name);
            if (racerExists)
            {
                data.Remove(data.Find(r => r.Name == name));
            }
            return racerExists;
        }

        public Racer GetRacer(string name) => data.Find(r => r.Name == name);

        public Racer GetOldestRacer() => data.OrderByDescending(r => r.Age).FirstOrDefault();

        public Racer GetFastestRacer() => data.OrderByDescending(r => r.Car.Speed).First();

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}:");
            foreach (var racer in data)
            {
                sb.AppendLine(racer.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
