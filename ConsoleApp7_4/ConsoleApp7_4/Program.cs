using System;

namespace ConsoleApp7_4
{
    class DatingProfile //1.1 Class
    {
        public string firstName; //1.2 Properties
        private string lastName;
        public int age;
        public string gender;
        public string bio;
        public DatingProfile(string inputFirstName, string inputLastName, int inputAge, string inputGender, string inputBio) //1.3 Constructor
        {
            this.firstName = inputFirstName;
            this.lastName = inputLastName;
            this.age = inputAge;
            this.gender = inputGender;
            this.bio = inputBio;
        }
        public void WriteBio(string text)
        {
            Console.WriteLine("What do you want your bio to say?");
            string userInput = Console.ReadLine();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 7.4: The Dating Game");


        }
    }
}
