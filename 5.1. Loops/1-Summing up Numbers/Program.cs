using System;
using System.Threading;

namespace _1_Summing_up_Numbers
{
    class Program
    {
        static void Main()
        {
            int numero = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 0; i < numero; i++)
            {
                int sum = int.Parse(Console.ReadLine());
                suma += sum;
            }

            Console.WriteLine("suma: {0}",suma);


            //Console.WriteLine("Abecedario!");
            //for (var letra = 'a'; letra < 'z'; letra++)
            //{

            //    Console.Write(letra);

            //}

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
