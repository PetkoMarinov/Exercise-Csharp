using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string firstString = input[0];
            string secondString = input[1];

            int result = Multiplayer(firstString, secondString);
            Console.WriteLine(result);
        }

        static int Multiplayer(string first, string second)
        {
            char[] firstChar = first.ToCharArray();
            char[] secondChar = second.ToCharArray();
            char[] longerArray = first.Length > second.Length
                ? firstChar : secondChar;

            int sum = 0;

            for (int i = 0; i < longerArray.Length; i++)
            {
                if (i < Math.Min(firstChar.Length, secondChar.Length))
                {
                    sum += firstChar[i] * secondChar[i];
                }
                else
                {
                    sum += longerArray[i];
                }
            }
            return sum;
        }
    }
}
