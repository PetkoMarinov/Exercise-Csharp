using System;
using System.Linq;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string stringJoin = string.Empty;
            while (lines > 0)
            {
                string input = Console.ReadLine();
                if (input == ('(').ToString() || input == (')').ToString())
                {
                    stringJoin += input;
                }
                lines--;
            }
            int count = stringJoin.Length;
            bool isTrue = true;

            for (int i = 0; i < stringJoin.Length - 1; i += 2)
            {
                if (stringJoin[i] != '(' || stringJoin[i + 1] != ')')
                {
                    isTrue = false;
                    break;
                }
            }

            if (isTrue && count % 2 == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
