using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(?: 2 |-2-)\d{3}(?: |-)\d{4}\b";

            string text = Console.ReadLine();

            MatchCollection phoneNumber = Regex.Matches(text, pattern);

            var matchedPhoneNums = phoneNumber
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ",matchedPhoneNums));
        }
    }
}
