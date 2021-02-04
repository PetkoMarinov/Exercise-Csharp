using System;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double total = 0;

            if (type == "students")
            {
                if (day == "friday")
                {
                    total = people * 8.45;
                }
                else if (day == "saturday")
                {
                    total = people * 9.80;
                }
                else if (day == "sunday")
                {
                    total = people * 10.46;
                }
                else { Console.WriteLine("Choose another day"); }

                if (people >= 30)
                {
                    total -= total * 0.15;
                }
            }

            else if (type == "business")
            {
                if (people >= 100)
                {
                    people -= 10;
                }

                if (day == "friday")
                {
                    total = people * 10.90;
                }
                else if (day == "saturday")
                {
                    total = people * 15.60;
                }
                else if (day == "sunday")
                {
                    total = people * 16;
                }
                else { Console.WriteLine("Choose another day"); }
            }

            else if (type == "regular")
            {
                if (day == "friday")
                {
                    total = people * 15;
                }
                else if (day == "saturday")
                {
                    total = people * 20;
                }
                else if (day == "sunday")
                {
                    total = people * 22.50;
                }
                else { Console.WriteLine("Choose another day"); }

                if (people >= 10 && people <= 20)
                {
                    total -= total * 0.05;
                }
            }

            else
            {
                Console.WriteLine("Wrong choice");
            }

            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
