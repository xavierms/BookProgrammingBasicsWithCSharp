using System;

namespace _2_Butterfly
{
    class Program
    {
        static void Main()
        {
            Console.Write("#:");
            int n = int.Parse(Console.ReadLine());

            int Midsize = n - 2;

            int col = 2 * n - 1;
            try
            {
                for (int i = 1; i <= Midsize; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine("{0}\\ /{0}", new string('*', Midsize));
                    }
                    else
                    {
                        Console.WriteLine("{0}\\ /{0}", new string('-', Midsize));

                    }
                }
                Console.WriteLine("{0} @{0}", new string(' ', Midsize));
                for (int i = 1; i <= Midsize; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine("{0}/ \\{0}", new string('*', Midsize));
                    }
                    else
                    {
                        Console.WriteLine("{0}/ \\{0}", new string('-', Midsize));

                    }
                }
            }
            catch (Exception xx)
            {

                Console.WriteLine("El numero debe ser mayor a 1!",xx.Message);

                Console.WriteLine("Presione una tecla para continuar...");
            }
            



            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
