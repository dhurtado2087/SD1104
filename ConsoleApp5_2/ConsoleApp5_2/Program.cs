using System;
using System.Collections.Generic;

namespace ConsoleApp5_2
{
    class Program
    {
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 5 2 Lab");

            List<string> taskList = new List<string>();

            foreach (WeekDays days in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine("Enter a new task for day " + days);
                string task = days + ":" + Console.ReadLine();
                taskList.Add(task);
            }
            foreach (string task in taskList)
            {
                Console.WriteLine(task);
            }
        }
    }
}
