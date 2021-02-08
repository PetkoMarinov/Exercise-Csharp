using System;

namespace CharactersInRange
{
    class CharactersInRange
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            
            PrintCharactersInRange(start, end);
        }

        static void PrintCharactersInRange(char start, char end)
        {
            for (char i = start; i < end; i++)
            {
                if (i==start)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
        }
    }
}
