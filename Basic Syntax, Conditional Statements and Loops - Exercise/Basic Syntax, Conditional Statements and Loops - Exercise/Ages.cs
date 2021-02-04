using System;

namespace Basic_Syntax__Conditional_Statements_and_Loops___Exercise
{
    class Ages
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            switch (age)
            {
                case int n when n >= 0 && n <= 2:
                    Console.WriteLine("baby"); break;
                case int n when n >= 3 && n <= 13:
                    Console.WriteLine("child"); break;
                case int n when n >= 14 && n <= 19:
                    Console.WriteLine("teenager"); break;
                case int n when n >= 20 && n <= 65:
                    Console.WriteLine("adult"); break;
                case int n when n >= 65:
                    Console.WriteLine("elder"); break;
                default:
                    Console.WriteLine("Wrong");
                    break;
            }
        }
    }
}
