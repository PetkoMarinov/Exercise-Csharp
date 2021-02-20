using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class SoftUniCoursePlanning
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();

            while (input.ToLower() != "course start")
            {
                string[] command = input.Split(":");
                switch (command[0].ToLower())
                {
                    case "add":
                        if (!lessons.Contains(command[1]))
                        {
                            lessons.Add(command[1]);
                        }
                        break;

                    case "insert":
                        if (!lessons.Contains(command[1]))
                        {
                            lessons.Insert(int.Parse(command[2]), command[1]);
                        }
                        break;

                    case "remove":
                        if (lessons.Contains(command[1]))
                        {
                            int removeIndex = lessons.IndexOf(command[1]);

                            if ((removeIndex + 1) < lessons.Count
                               && lessons[removeIndex + 1].Contains("-"))
                            {
                                lessons.RemoveAt(removeIndex + 1);
                            }
                            lessons.RemoveAt(removeIndex);
                        }
                        break;

                    case "swap":
                        if (lessons.Contains(command[1]) && lessons.Contains(command[2]))
                        {
                            int index1 = lessons.IndexOf(command[1]);
                            int index2 = lessons.IndexOf(command[2]);
                            lessons[index1] = command[2];
                            lessons[index2] = command[1];

                            if (index1 < index2)
                            {
                                if ((index1 + 1) < lessons.Count
                                && lessons[index1 + 1].Contains("-"))
                                {
                                    string exercise = lessons[index1 + 1];
                                    lessons.RemoveAt(index1 + 1);
                                    lessons.Insert(index2 + 1, exercise);
                                }

                                if ((index2 + 1) < lessons.Count
                                    && lessons[index2 + 1].Contains("-"))
                                {
                                    string exercise = lessons[index2 + 1];
                                    lessons.RemoveAt(index2 + 1);
                                    lessons.Insert(index1 + 1, exercise);
                                }
                            }
                            else
                            {
                                if ((index2 + 1) < lessons.Count
                                && lessons[index2 + 1].Contains("-"))
                                {
                                    string exercise = lessons[index2 + 1];
                                    lessons.RemoveAt(index2 + 1);
                                    lessons.Insert(index1 + 1, exercise);
                                }

                                if ((index1 + 1) < lessons.Count
                                    && lessons[index1 + 1].Contains("-"))
                                {
                                    string exercise = lessons[index1 + 1];
                                    lessons.RemoveAt(index1 + 1);
                                    lessons.Insert(index2 + 1, exercise);
                                }
                            }

                        }
                        break;

                    case "exercise":
                        if (lessons.Contains(command[1]))
                        {
                            if ((lessons.IndexOf(command[1]) + 1) < lessons.Count)
                            {
                                lessons.Insert(lessons.IndexOf(command[1]) + 1,
                                lessons[lessons.IndexOf(command[1])] + "-Exercise");
                            }
                            else
                            {
                                lessons.Add(command[1] + "-Exercise");
                            }

                        }
                        else
                        {
                            lessons.Add(command[1]);
                            lessons.Add(command[1] + "-Exercise");
                        }
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }

            foreach (var item in lessons)
            {
                Console.WriteLine(lessons.IndexOf(item) + 1 + "." + item);
            }
        }
    }
}