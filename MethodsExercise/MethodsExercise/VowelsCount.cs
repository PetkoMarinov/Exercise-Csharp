using System;

namespace MethodsExercise
{
    class VowelsCount
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(VowelsCounter(input));
        }

        static int VowelsCounter(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (char.ToLower(input[i]))
            {
                    case 'a':
                    case 'e':
                    case 'o':
                    case 'u':
                    case 'i':
                        counter++;break;
                    default: 
                        break;
                }
            }
            return counter;
        }
    }
}
