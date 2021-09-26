using System;

namespace _5_Digits
{
    class Program
    {
        static void Main()
        {
            int numero = int.Parse(Console.ReadLine());

            int uno  = 0;
            int dos  = 0;
            int tres = 0;

            // para sacar los numero de los digito dependa el indice
            uno  = numero / 100 % 10;
            dos = numero / 10 % 10;
            tres = numero / 1 % 10;

            //para organizar la impresion dependiendo de la filas y columnas
            int fila = uno + dos;
            int col = uno + tres;

            
            for (int i = 0; i < fila; i++)
            {
                for (int L = 0; L < col; L++)
                {
                if (numero % 5 == 0)
                {
                    numero -= uno;
                   
                }
                else if(numero % 3 == 0)
                {
                    numero -= dos;
                }
                else 
                {
                    numero += tres;
                }

                Console.Write(numero + ", ");
                }
                Console.WriteLine();
            }
                



            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
