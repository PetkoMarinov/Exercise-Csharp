using System;
using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string []memberInfo = Console.ReadLine().Split();
                family.AddMember(memberInfo);
            }

            Person oldest = family.GetOldestMember();

            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }

    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Family
    {

        public List<Person> FamilyMembers { get; set; } = new List<Person>();

        public void AddMember(string[] memberInfo)
        {
            Person newMember = new Person(memberInfo[0], int.Parse(memberInfo[1]));
            FamilyMembers.Add(newMember);
        }

        public Person GetOldestMember()
        {
            return FamilyMembers.OrderByDescending(x => x.Age).First();
        }
    }
}