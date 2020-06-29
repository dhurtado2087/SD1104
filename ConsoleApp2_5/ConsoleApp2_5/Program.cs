using System;

namespace ConsoleApp2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2.5");

            
            //1. Write a C# program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
            Console.WriteLine("First number?");
            string inputOne = Console.ReadLine();
            Console.WriteLine("Second number?");
            string inputTwo = Console.ReadLine();

            int numberOne = int.Parse(inputOne);
            int numberTwo = int.Parse(inputTwo);

            Console.WriteLine(numberOne + " + " + numberTwo + " = " + (numberOne + numberTwo));
            Console.WriteLine(numberOne + " - " + numberTwo + " = " + (numberOne - numberTwo));
            Console.WriteLine(numberOne + " x " + numberTwo + " = " + (numberOne * numberTwo));
            Console.WriteLine(numberOne + " / " + numberTwo + " = " + (numberOne / numberTwo));


            //2. Write a C# program to print Hello and your name (which you will type in on the Console) in a separate line.
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName);


            //3. Write a C# program to print the output of multiplication of three numbers which will be entered by the user
            Console.WriteLine("Now we will multiply 3 numbers.");
            
            Console.WriteLine("Choose the first number:");
            string userNumOne = Console.ReadLine();
            int numb1 = int.Parse(userNumOne);
            
            Console.WriteLine("Second number:");
            string userNumTwo = Console.ReadLine();
            int numb2 = int.Parse(userNumTwo);
            
            Console.WriteLine("Third:");
            string userNumThree = Console.ReadLine();
            int numb3 = int.Parse(userNumThree);

            Console.WriteLine(userNumOne + " x "  + userNumTwo + " x " + userNumThree + " = " + (numb1 * numb2 * numb3));

            //4. Write a C# program that takes an age (for example 20) as input and prints something like "You look younger than 20 (the age the user entered)".
            Console.WriteLine("Almost done. Last question, what's your age?");
            string userAge = Console.ReadLine();
            Console.WriteLine("You look younger than " + userAge);


        }
    }
}
