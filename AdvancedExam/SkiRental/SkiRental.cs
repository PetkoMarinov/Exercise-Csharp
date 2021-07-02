using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> data;

        public SkiRental(string name, int capacity)
        {
            this.data = new List<Ski>();
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get => this.data.Count; }

        public void Add(Ski ski)
        {
            if (Capacity > Count)
            {
                data.Add(ski);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            bool skiExists =
                data.Exists(s => s.Manufacturer == manufacturer && s.Model == model);
            if (skiExists)
            {
                data.Remove(data.Find(s => s.Manufacturer == manufacturer && s.Model == model));
            }
            return skiExists;
        }

        public Ski GetNewestSki() => data.OrderByDescending(s => s.Year).FirstOrDefault();

        public Ski GetSki(string manufacturer, string model)
        {
            if (data.Exists(s => s.Manufacturer == manufacturer && s.Model == model))
            {
                return data.Find(s => s.Manufacturer == manufacturer && s.Model == model);
            }
            return null;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");
            foreach (var ski in data)
            {
                sb.AppendLine(ski.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
