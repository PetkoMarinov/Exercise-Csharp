using System;
using System.Linq;
using System.Collections.Generic;

namespace ListExercise
{
    class HouseParty
    {
        static void Main(string[] args)
        {
            int commandLines = int.Parse(Console.ReadLine());
            List<string> partyPeople = new List<string>(commandLines);

            for (int i = 0; i < commandLines; i++)
            {
                string command = Console.ReadLine();
                string guest = command.Substring(0, command.IndexOf(" "));
                if (command.Split().Length > 3)
                {
                    if (partyPeople.Contains(guest))
                    {
                        partyPeople.Remove(guest);
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not in the list!");
                    }
                }
                else
                {
                    if (partyPeople.Contains(guest))
                    {
                        Console.WriteLine($"{guest} is already in the list!");
                    }
                    else
                    {
                        partyPeople.Add(guest);
                    }
                }
            }
            Console.WriteLine(string.Join("\n", partyPeople));
        }
    }
}