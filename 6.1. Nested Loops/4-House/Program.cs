using System;

namespace _4_House
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int espacio = (n - 1) / 2;
            int estrella = 1;

            if (n % 2 == 0 )
            {
                estrella = 2;
            }

            for (int row = 0; row < (n - 1) / 2; row++)
            {
                Console.Write(new string('-', espacio));
                Console.Write(new string('*', estrella));
                Console.Write(new string('-', espacio));

                Console.WriteLine();

                estrella +=2;
                espacio--;
            }

            //base
            for (int i = 0; i < n / 2; i++)
            {
                var line = "|" + new string('*', n - 2) + "|";
                 Console.WriteLine(line);
            }

            //for (int row = 1; row <= n; row++)
            //{
            //    //columnas

            //    //n - row , para los espacios en blanco.
            //    for (int col = 1; col <= n - row; col++)
            //    {
            //        Console.Write("-");
            //    }
            //    //despues de los espacios agraga un  *
            //    Console.Write("**");

            //    for (int col = 1; col < row; col++)
            //    {
            //        Console.Write("**");
            //    }
            //    Console.WriteLine("-");

        
            //   //  Console.WriteLine("-");
            //    }
        



                //Detener el prog, borrar y retornar al metodo main "inicio"
                Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
