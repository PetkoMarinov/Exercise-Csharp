using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue<int> ingredients = new Queue<int>(Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            //Stack<int> freshness = new Stack<int>(Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            //List<string> dishes = new List<string>();

            //while (ingredients.Count>0 && freshness.Count>0)
            //{
            //    while (ingredients.Peek() == 0)
            //    {
            //        ingredients.Dequeue();
            //    }

            //    if (ingredients.Count == 0 || freshness.Count == 0)
            //    {
            //        break;
            //    }
            //    int ingredient = ingredients.Peek();
            //    int fresh = freshness.Peek();
            //    int dishPoints = ingredient * fresh;

            //    switch (dishPoints)
            //    {
            //        case 150:
            //            dishes.Add("Dipping sauce");
            //            ingredients.Dequeue();
            //            freshness.Pop(); break;
            //        case 250:
            //            dishes.Add("Green salad");
            //            ingredients.Dequeue();
            //            freshness.Pop(); break;
            //        case 300:
            //            dishes.Add("Chocolate cake");
            //            ingredients.Dequeue();
            //            freshness.Pop(); break;
            //        case 400:
            //            dishes.Add("Lobster");
            //            ingredients.Dequeue();
            //            freshness.Pop(); break;
            //        default:
            //            freshness.Pop();
            //            ingredients.Enqueue(ingredients.Dequeue() + 5);
            //            break;
            //    }
            //}

            //var distinctDishes = dishes.Distinct().ToList();
            //int distinctCount = dishes.Distinct().ToList().Count;

            //if (distinctCount >= 4)
            //{
            //    Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            //}
            //else
            //{
            //    Console.WriteLine("You were voted off. Better luck next year.");
            //    if (ingredients.Count() > 0)
            //    {
            //        Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            //    }
            //}

            //if (distinctCount>0)
            //{
            //    foreach (var dish in distinctDishes.OrderBy(d => d))
            //    {
            //        Console.WriteLine($"# {dish} --> " +
            //            $"{dishes.Where(d => d == dish).ToList().Count}");
            //    }
            //}

            Dictionary<string, object> test = new Dictionary<string, object>();
            test.Add("petko", 2);
            test.Add("kiro", "shpeka");
            test["petko"] += "patka";
          //  test.Add("petko", "patka");
        }
    }
}

