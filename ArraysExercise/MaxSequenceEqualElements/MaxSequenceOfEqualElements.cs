using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = -1;
            int counter = 1;
            int tempIndex = -1;
            int tempCounter = 1;
            string digit = string.Empty;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    tempCounter++;
                    tempIndex = i - tempCounter + 2;
                }
                else
                {
                    tempCounter = 1;
                }

                if (counter < tempCounter || arr.Max() == arr.Min())
                {
                    counter = tempCounter;
                    index = tempIndex;
                    digit = (arr[i]).ToString();
                }
            }

            if (index == -1)
            {
                Console.WriteLine(arr[0]);
            }
            else if (index != -1 && index <= 1)
            {
                for (int k = 1; k <= counter; k++)
                {
                    Console.Write(digit + " ");
                }
            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    if (arr[i] == arr[i + 1])
                    {
                        tempCounter++;
                        tempIndex = i - tempCounter + 2;
                    }
                    else
                    {
                        tempCounter = 1;
                    }

                    if (tempCounter == counter)
                    {
                        index = tempIndex;
                        digit = (arr[i]).ToString();
                        break;
                    }
                }

                for (int k = 1; k <= counter; k++)
                {
                    Console.Write(digit + " ");
                }
            }
        }
    }
}
