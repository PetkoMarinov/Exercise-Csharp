using System;
using System.Linq;

namespace _5._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            Func<int, int> mathOperation = x => x;
            Action<int[]> print = nums => Console.WriteLine(string.Join(" ", nums));

            while (command != "end")
            {
                if (arr.Length == 0)
                {
                    break;
                }
                switch (command)
                {
                    case "add": mathOperation = x => x + 1;
                        arr = arr.Select(mathOperation).ToArray(); break;
                    case "multiply": mathOperation = x => x * 2;
                        arr = arr.Select(mathOperation).ToArray(); break;
                    case "subtract": mathOperation = x => x - 1;
                        arr = arr.Select(mathOperation).ToArray(); break;
                    case "print": print(arr); break;
                }
                
                command = Console.ReadLine();
            }
        }
    }
}
