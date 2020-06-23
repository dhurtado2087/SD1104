using System;

namespace ConsoleApp5_6
{
    class Program
    {
        struct Customer
        {
            public string firstName;
            public string lastName;
            public int age;
            public bool premiumMembership;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 5.6 Lab: If Statement");

            Customer customerOne = new Customer
            {
                firstName = "Miles",
                lastName = "Morales",
                age = 14,
                premiumMembership = false
            };

            Customer customerTwo = new Customer
            {
                firstName = "Peter",
                lastName = "Parker",
                age = 22,
                premiumMembership = false
            };

            Customer customerThree = new Customer
            {
                firstName = "Tony",
                lastName = "Stark",
                age = 35,
                premiumMembership = true
            };

            int age = customerTwo.age;
            bool status = customerTwo.premiumMembership;
            if (age > 21 & status == true)
            {
                Console.WriteLine("This customer has a premium membership and is of age.");
            }
            else if (age > 21 & status == false)
            {
                Console.WriteLine("This customer does not have a permium membership but can still order.");
            }
            else
            {
                Console.WriteLine("This customer is under age and cannot place an order.");
            }
        }
    }
}
