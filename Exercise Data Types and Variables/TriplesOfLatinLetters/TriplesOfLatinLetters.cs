using System;

namespace TriplesOfLatinLetters
{
    class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            //Write a program to read an integer n and print all triples of the
            //first n small Latin letters, ordered alphabetically:
            int num = int.Parse(Console.ReadLine());
            for (char a = 'a'; a < 'a' + num; a++)
            {
                for (char b = 'a'; b < 'a' + num; b++)
                {
                    for (char c = 'a'; c < 'a' + num; c++)
                    {
                        Console.Write($"{a}{b}{c}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
