using System;

namespace _1_Drawing_a_Fort
{
    class Program
    {
        static void Main()
        {
            Console.Write("#:");
            
            int n = int.Parse(Console.ReadLine());

            
            var col = n / 2;
            var mid = 2 * n - 2 * col -4;

            Console.WriteLine("");
            try
            {
                //parte arriba
                Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', col), new string('_', mid));

                for (int fila = 1; fila < n - 3; fila++)
                {

                    Console.WriteLine($"|{ new string(' ', 2 * n - 2) }|");
                }
                //mitad
                Console.WriteLine("|{0}{1}{0}|", new string(' ', col + 1), new string('_', mid));

                //parte abajo
                Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', col), new string(' ', mid));

                //Console.Write("\\");
                //Console.Write(new string('_', n));
                //Console.Write("/");
                //Console.Write("\\");
                //Console.Write(new string('_', n));
                //Console.WriteLine("/");

            }
            catch (Exception msj)
            {

                Console.WriteLine("El numero debe ser 3 o mayor.!", msj.Message);
            }
            

            //Console.Write("/");
            //Console.Write(new string('^',n ) );
            //Console.Write("\\");
            //Console.Write("/");
            //Console.Write(new string('^', n));
            //Console.WriteLine("\\");

           
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
