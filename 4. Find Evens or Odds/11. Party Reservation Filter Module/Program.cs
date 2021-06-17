using System;

namespace _11._Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');

            string input = Console.ReadLine();
            Action<string[]> print = text => Console.WriteLine(string.Join(" ",text));
            Func<string>

            while (input!="Print")
            {
                string command = input.Split(';')[0];
                string prfm = input.Split(';')[1];
                string filterParameter = input.Split(';')[2];


            }


        }
    }
}
