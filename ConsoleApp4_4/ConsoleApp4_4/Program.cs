using System;
using System.Collections.Generic;

namespace ConsoleApp4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 4.4: Improved Spam Checker");

            List<string> blackListWord = new List<string>();
            blackListWord.Add("buy");
            blackListWord.Add("viagra");
            blackListWord.Add("xxx");
            blackListWord.Add("free money");
            blackListWord.Add("lifetime offer");
            blackListWord.Add("send money");
            blackListWord.Add("bank account");
            blackListWord.Add("nigeria");
            blackListWord.Add("online");
            blackListWord.Add("pharmacy");
            blackListWord.Add("h8te");
            blackListWord.Add("meet girls");
            
            bool isSpam = false;
            string message = Console.ReadLine();
            message = message.ToLower();

            for (int i = 0; i < blackListWord.Count; i++)
            {
                if (message.Contains(blackListWord[i]))
                {
                    isSpam = true;
                }
            }
            if (isSpam == true)
            {
                isSpam = true;
                Console.WriteLine("The message is spam");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("The message is not spam.");
            }
        }
    }
}
