using System;

namespace _5_Diamond
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            int izquierda = (n - 1) / 2;
            int derecha   = n / 2;
            //int izqDerecha = (n - 1) / 2;

            for (int fila  = 0; fila < ( n - 1 )/ 2 ; fila++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == izquierda || col == derecha)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");

                    }
                }
                Console.WriteLine();
                izquierda--;
                derecha++;
            }
            Console.Write('*');
            Console.Write(new string('-', n - 2));
            Console.Write('*');
            Console.WriteLine();
            izquierda = 1;
            derecha = n - 2;

            for (int fila = 0; fila < (n - 1) / 2; fila++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == izquierda || col == derecha)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");

                    }
                }
                Console.WriteLine();
                izquierda++;
                derecha--;
            }
            //Detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
