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
            for (int i = 0; i < n * 2; i++)
            {               
                Console.WriteLine($"{new string('.', n * 2 - 1 -i)}*{new string('-',i)}*{new string('-', i)}*{new string('.', n * 2 - 1 -i)}");   
            }
           
            //parte baja
            Console.WriteLine(new string('*', n * 4 + 1));
            for (int i = 0; i < n * 4 + 1; i++)
            {
               
                if (i % 2 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            Console.Write(new string('*', n * 4 + 1));

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
