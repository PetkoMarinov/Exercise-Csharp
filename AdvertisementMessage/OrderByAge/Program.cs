using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    public class Person
    {
        public Person()
        {

        }

        public string name { get; set; }

        public string ID { get; set; }

        public string age { get; set; }

        public override string ToString()
        {
            return $"{name} with ID: {ID} is {age} years old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] data = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            while (data[0] != "End")
            {
                Person person = new Person()
                {
                    name = data[0],
                    ID = data[1],
                    age = data[2]
                };

                people.Add(person);

                data = Console.ReadLine().Split();
            }

            people = people.OrderBy(x => int.Parse(x.age)).ToList();

            Console.Write(string.Join("\n", people));
        }
    }
}
