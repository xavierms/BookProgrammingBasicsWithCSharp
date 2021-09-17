using System;

namespace Greeting_by_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string person = Console.ReadLine();
            
            Console.WriteLine("Hello, {0}", person);
        }
    }
}
