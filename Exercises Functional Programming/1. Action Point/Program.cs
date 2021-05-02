using System;

namespace _1._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = x => Console.WriteLine(x);
            string[] text = Console.ReadLine().Split();
            print(string.Join("\n", text));
        }
    }
}
