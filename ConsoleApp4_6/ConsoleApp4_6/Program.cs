using System;

namespace ConsoleApp4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 4.6: Array To Do List");
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] tasks = new string[7];

            Console.WriteLine("Welcome to your daily planner.");

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine("Type in the new task for " + days[i]);
                tasks[i] = days[i] + ": " + Console.ReadLine();

            }

            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine(tasks[i]);
            }
        }
    }
}
