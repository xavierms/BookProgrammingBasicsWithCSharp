using System;

namespace Guess_the_Password
{
    class Program
    {
        static void Main(string[] args)
        {

            // s3cr3t! P@ssw0rd
            Console.Write("Password: ");
            string pass = Console.ReadLine();

            if (pass == "s3cr3t! P@ssw0rd")
            {
                Console.WriteLine("!Welcome!");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
