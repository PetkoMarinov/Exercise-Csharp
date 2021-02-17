using System;
using System.Collections.Generic;

namespace BitwiseOperationsLab
{
    class BitwiseOperationsLab
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int binary = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();

            while (num > 0)
            {
                int reminder = num % 2;
                result.Add(reminder);
                num /= 2;
            }
            result.Reverse();

            int counter = 0;

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] == binary)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
           // Console.WriteLine(Convert.ToString(num, 2));
        }
    }
}
