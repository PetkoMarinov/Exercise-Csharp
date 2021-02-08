using System;
using System.Linq;

namespace CaminoFactory
{
    class CaminoFactory
    {
        static void Main(string[] args)
        {
            int linesLength = int.Parse(Console.ReadLine());
            int bestLine = 0;
            int bestIndex = 0;
            int bestCounter = 1;
            int tempLine = 0;
            int bestSum = 0;
            int[] bestArray = new int[linesLength];

            string input = Console.ReadLine();

            while (input != "Clone them!")
            {
                int[] tempArr = input.Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                int tempIndex = -1;
                int tempCounter = 1;
                int tempSum = tempArr.Sum();
                tempLine++;

                for (int i = 0; i < tempArr.Length - 1; i++)
                {
                    if (tempArr[i] == tempArr[i + 1]) //&& tempArr[i] == 1)
                    {
                        tempCounter++;
                        tempIndex = i - tempCounter + 2;
                    }
                    else
                    {
                        tempCounter = 1;
                    }

                    if (bestCounter < tempCounter)
                    {
                        bestCounter = tempCounter;
                        bestIndex = tempIndex;
                        bestLine = tempLine;
                        bestArray = tempArr.ToArray();
                        bestSum = bestArray.Sum();
                    }
                    else if (bestCounter == tempCounter)
                    {
                        if (tempIndex < bestIndex && tempIndex!=-1)
                        {
                            bestIndex = tempIndex;
                            bestLine = tempLine;
                            bestArray = tempArr.ToArray();
                            bestSum = bestArray.Sum();
                        }
                        else 
                        {
                            if (bestSum < tempSum)
                            {
                                bestLine = tempLine;
                                bestArray = tempArr.ToArray();
                                bestSum = bestArray.Sum();
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestLine} with sum: " +
               $"{bestSum}.");
            Console.WriteLine(string.Join(" ", bestArray));
        }
    }
}