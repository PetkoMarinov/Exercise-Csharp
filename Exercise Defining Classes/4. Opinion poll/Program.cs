using System;

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person()
            //{
            //    Name = "Pesho",
            //    Age = 20
            //};

            //Person person2 = new Person("Gosho",18);

            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            while (n > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
                n--;
            }

            family.PrintOlderThan30();

        }
    }
}
