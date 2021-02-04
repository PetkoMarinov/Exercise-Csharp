using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalExpenses =
                    (students + Math.Ceiling(students * 0.10)) * sabrePrice +
                     (students - students / 6) * beltPrice + students * robePrice;


            if (money>=totalExpenses)
            {
                Console.WriteLine("The money is enough - " +
                    $"it would cost {totalExpenses:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(money-totalExpenses):f2}" +
                    $"lv more.");
            }
        }
    }
}
