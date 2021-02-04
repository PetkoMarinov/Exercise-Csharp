using System;

namespace ZigZagArrays
{
    class ZigZagArrays
    {
        static void Main(string[] args)
        {
            //Write a program which creates 2 arrays. You will be given an integer n.
            //On the next n lines you get 2 integers. Form 2 arrays as shown below.

            int lines = int.Parse(Console.ReadLine());
            int[] firstLine = new int[lines];
            int[] secondLine = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (i%2==0)
                {
                    firstLine[i] = int.Parse(input[0]);
                    secondLine[i] = int.Parse(input[1]);
                }
                else
                {
                    firstLine[i] = int.Parse(input[1]);
                    secondLine[i] = int.Parse(input[0]);
                }
            }
            Console.WriteLine(string.Join(" ", firstLine));
            Console.WriteLine(string.Join(" ", secondLine));
        }
    }
}
