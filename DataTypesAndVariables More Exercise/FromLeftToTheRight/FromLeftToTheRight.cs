using System;

namespace FromLeftToRight
{
    class FromLeftToTheRight
    {
        static void Main(string[] args)
        {
            byte num = byte.Parse(Console.ReadLine());
            while (num > 0)
            {
                num--;
                string input = Console.ReadLine();
                long right = long.Parse(input.Substring(input.IndexOf(' ') + 1));
                long left = long.Parse(input.Substring(0, input.IndexOf(' ')));
                string biggerNum = left > right
                                    ? Math.Abs(left).ToString()
                                    : Math.Abs(right).ToString();

                double sum = 0;
                for (int i = 0; i < biggerNum.Length; i++)
                {
                    sum += char.GetNumericValue(biggerNum[i]);
                }
                Console.WriteLine(sum);
            }
        }
    }
}
