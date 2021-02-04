using System;

namespace DecryptingMessages
{
    class DecryptingMessages
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            byte linesInput = byte.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 0; i < linesInput; i++)
            {
                char charInput = char.Parse(Console.ReadLine());
                result += (char)(charInput + key);
            }
            Console.WriteLine(result);
        }
    }
}
