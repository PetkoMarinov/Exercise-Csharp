using System;
using System.Collections.Generic;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            string command = Console.ReadLine();

            Queue<string> queue = new Queue<string>(songs);

            while (queue.Count > 0)
            {
                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command.Split(" ", 2)[0] == "Add")
                {
                    string songToAdd = command.Split(" ", 2)[1];
                    bool found = false;

                    foreach (var song in queue)
                    {
                        if (song == songToAdd)
                        {
                            Console.WriteLine($"{song} is already contained!");
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        queue.Enqueue(songToAdd);
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(", ", queue));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
