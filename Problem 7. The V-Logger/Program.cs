using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<  string, Dictionary<string, HashSet<string>>> vloggers =
                new Dictionary<string, Dictionary<string, HashSet<string>>>();

            while (input != "Statistics")
            {
                string[] info = input.Split(' ', 3, StringSplitOptions.RemoveEmptyEntries);
                string command = info[1];
                string logger = info[0];
                string followedUser = info[2];

                if (!vloggers.ContainsKey(logger))
                {
                    vloggers.Add(logger, new Dictionary<string, HashSet<string>>());
                }

                if (!vloggers.ContainsKey(followedUser))
                {
                    vloggers.Add(followedUser, new Dictionary<string, HashSet<string>>());
                }

                vloggers[logger] = new Dictionary<string, HashSet<string>>()
                    {
                        { "following",new HashSet<string>()},
                        { "followed",new HashSet<string>()}
                    };

                vloggers[followedUser] = new Dictionary<string, HashSet<string>>()
                    {
                        { "following",new HashSet<string>()},
                        { "followed",new HashSet<string>()}
                    };

                if (command == "followed")
                {
                    string follower = logger;
                    if (followedUser != follower)
                    {
                        vloggers[follower]["following"].Add(followedUser);
                        vloggers[followedUser]["followed"].Add(follower);
                    }
                }

                input = Console.ReadLine();
            }

            int count = 1;
            Console.WriteLine($"The V-Logger has a total of {vloggers.Keys.Count}" +
                $" vloggers in its logs.");

            vloggers = vloggers
                .OrderByDescending(v => v.Value["followed"].Count)
                .ThenBy(v => v.Value["following"].Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var vlogger in vloggers)
            {
                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value["followed"].Count}" +
                    $" followers, {vlogger.Value["following"].Count} following");

                if (count == 1)
                {
                    foreach (string follower in vlogger.Value["followed"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                count++;
            }
        }
    }
}
