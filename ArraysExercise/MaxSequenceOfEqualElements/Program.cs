using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startIndex = -1;
            int counter = 1;
            int tempIndex = -1;
            int tempCounter = 1;
            string digit = string.Empty;

            string[] temp = new string[arr.Length];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    tempCounter++;
                    tempIndex = i - tempCounter + 2;
                }
                else if (counter<tempCounter)
                {
                    counter = tempCounter;
                    startIndex = tempIndex;
                    digit = (arr[i]).ToString();
                }
                else
                {
                    tempCounter = 1;
                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                if(arr[i] == arr[i + 1])
                {
                    tempCounter++;
                    tempIndex = i - tempCounter + 2;
                }
                else if (counter == tempCounter)
                {
                    startIndex = tempIndex;
                    digit = (arr[i]).ToString();
                }
                else
                {
                    tempCounter = 1;
                }
            }


           
        }
    }
}
