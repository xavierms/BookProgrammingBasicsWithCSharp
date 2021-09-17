using System;

namespace _11_Identical_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Word 1: ");
            var word = Console.ReadLine().ToLower();
            
            Console.Write("Word 2: ");
            var comparate = Console.ReadLine().ToLower();

            if (word == comparate)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
