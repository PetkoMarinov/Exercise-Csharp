using System;

namespace _5._Date_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();
            
            DateModifier dateModifier = new DateModifier();

            Console.WriteLine(dateModifier.DaysBetweenTwoDays(date1,date2));
        }
    }
}
