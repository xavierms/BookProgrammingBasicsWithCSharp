using System;

namespace _5_Christmas_Hat
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            //punta del gorro
            Console.Write(new string('.',n *2 -1));
            Console.Write("/|\\");
            Console.WriteLine(new string('.', n * 2 - 1));

            Console.Write(new string('.', n * 2 - 1));
            Console.Write("\\|/");
            Console.WriteLine(new string('.', n * 2 - 1));

            //medio
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', n * 2 - 1));
                Console.WriteLine("***");
            }


            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
