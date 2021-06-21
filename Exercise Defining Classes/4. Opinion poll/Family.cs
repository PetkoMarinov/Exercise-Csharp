using System.Collections.Generic;
using System.Linq;
using System;

namespace DefiningClasses
{
    class Family
    {
        private readonly HashSet<Person> members;

        public Family()
        {
            this.members = new HashSet<Person>();
        }

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldest = this.members.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldest;
        }

        public void PrintOlderThan30()
        {
            var older = this.members.Where(x=>x.Age>30).OrderBy(x=>x.Name).ToHashSet();
            foreach (var old in older)
            {
                Console.WriteLine($"{old.Name} - {old.Age}");
            }
            
        }
    }
}
