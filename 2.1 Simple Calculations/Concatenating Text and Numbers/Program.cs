using System;

namespace Concatenating_Text_and_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Age: ");
            int age = Int32.Parse(Console.ReadLine());

            Console.Write("Town: ");
            string town = Console.ReadLine();


            Console.WriteLine("You are {0}, {1}, a {2}-years old person from {3}.", 
                firstName, 
                lastName, 
                age, 
                town);
        }
    }
}
