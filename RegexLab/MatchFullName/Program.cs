using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string text = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(text, pattern);

            Console.Write(string.Join(" ", matchedNames));

        }
    }
}
