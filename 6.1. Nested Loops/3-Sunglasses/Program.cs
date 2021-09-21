using System;

namespace _3_Sunglasses
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //parte superior
            Console.Write(new string('*',2 * n));
            Console.Write(new string(' ', n));
            Console.Write(new string('*',2 * n));
            Console.WriteLine();

            for (int fila = 0; fila < n - 2; fila++)
            {
                //relleno de "/" izquierdo
                Console.Write('*');
                Console.Write(new string('/', (n * 2) - 2));
                Console.Write('*');

                if (fila + 1 == (n - 1) / 2 )
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));


                }
                //relleno de "/" derecho
                Console.Write('*');
                Console.Write(new string('/', (n * 2) - 2));
                Console.Write('*');
                Console.WriteLine();
            }

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.Write(new string('*', 2 * n));

            for (int i = 0; i < n - 2; i++)
            {

                
                Console.WriteLine();
            }

            //Detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
