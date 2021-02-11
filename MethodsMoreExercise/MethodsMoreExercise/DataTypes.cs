using System;

namespace MethodsMoreExercise
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            PrintResult(firstInput, secondInput);
        }

        static void PrintResult(string firstInput, string secondInput)
        {
            if (firstInput == "int".ToLower())
            {
                Console.Write(int.Parse(secondInput) *2);
            }
            else if (firstInput == "real".ToLower())
            {
                Console.Write($"{ (double.Parse(secondInput) * 1.5):f2}");
            }
            else if (firstInput == "string".ToLower())
            {
                Console.Write('$' + secondInput + '$');
            }
        }
    }
}
