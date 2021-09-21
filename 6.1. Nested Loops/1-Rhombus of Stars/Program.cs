using System;

namespace _1_Rhombus_of_Stars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());


            int colS = 1;
            for (int row = 0; row < n - 1; row++)
            {
                Console.Write(new string(' ', n - colS));
                for (int col = 0; col < colS; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                colS++;
            }
            for (int col = 0; col < n; col++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

            colS = n - 1;
            for (int row = 0; row < n - 1; row++)
            {
                Console.Write(new string(' ', n - colS));
                for (int col = 0; col < colS; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                colS--;
            }





            //2da forma-----------------------------------------------

            //filas
            //for (int row = 1; row <= n; row++)
            //{
            //    //columnas

            //    //n - row , para los espacios en blanco.
            //    for (int col = 1; col <= n - row; col++)
            //    {
            //        Console.Write("-");
            //    }
            //    //despues de los espacios agraga un  *
            //    Console.Write("*");

            //    for (int col = 1; col < row; col++)
            //    {
            //        Console.Write("-*");
            //    }
            //    Console.WriteLine("-");

            //    for (int row2 = n; row2 <= row; row2++)
            //    {

            //        for (int col = 1; col <= row - 2; col++)
            //        {
            //            Console.Write("-");
            //        }
            //        Console.Write("*");

            //        for (int col = 1; col < row - 1; col++)
            //        {
            //            Console.Write("-*");
            //        }
            //        Console.WriteLine("-");
            //    }


            //hace un salto de linea hacia la siguente fila
            //Console.WriteLine("-");



        //}

            //Detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
