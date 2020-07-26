using System;
using System.Collections.Generic;

namespace ConsoleApp4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 4.5: The Trivia Website Leaderboard");

            List<int> scores = new List<int>();
            scores.Add(4400);
            scores.Add(8900);
            scores.Add(1200);
            scores.Add(3700);
            scores.Add(7200);

            Console.WriteLine("Original list");
            foreach (var item in scores)
            {
                Console.WriteLine(item);
            }

            scores.Sort();
            Console.Write("List in ascending order");
            foreach (var item in scores)
            {
                Console.WriteLine(item);
            }

            scores.Reverse();
            Console.WriteLine("List in descending order");
            foreach (var item in scores)
            {
                Console.WriteLine(item);
            }

            scores.Add(2400);

            scores.Remove(4400);

            Console.WriteLine("Altered list");
            foreach (var item in scores)
            {
                Console.WriteLine(item);
            }
        }
    }
}
