using System;

namespace _4_Arrow
{
    class Program
    {
        static void Main()
        {
            Console.Write("#:");
            int n = int.Parse(Console.ReadLine());

            int puntosFuera  = (n  - 1) / 2;
            int puntosDentro = n  - 2;
        
            try
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("El numero tiene que ser impar!");
                }
                else
                {


                    //------------
                    Console.WriteLine("{0}{1}{0}",
                        new string('.', puntosFuera),
                        new string('#', n));

                    //mid-----------
                    for (int i = 0; i < n - 2; i++)
                    {
                        Console.WriteLine("{0}#{1}#{0}",
                       new string('.', puntosFuera),
                       new string('.', puntosDentro));
                    }
                    Console.WriteLine("{0}{1}{0}",
                       new string('#', puntosFuera + 1),
                       new string('.', puntosDentro));

                    //abajo
                    puntosFuera = 1;
                    puntosDentro = 2 * n - 5;

                    for (int i = 0; i < n - 2; i++)
                    {
                        Console.WriteLine("{0}#{1}#{0}",
                      new string('.', puntosFuera),
                      new string('.', puntosDentro));

                        puntosFuera++;
                        puntosDentro -= 2;
                    }
                    Console.WriteLine("{0}#{0}",
                        new string('.', puntosFuera));
                }
            }
            catch (Exception xx)
            {

                Console.WriteLine("El numero debe ser mayor de 1! \n"+ xx.Message);
            }




            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
