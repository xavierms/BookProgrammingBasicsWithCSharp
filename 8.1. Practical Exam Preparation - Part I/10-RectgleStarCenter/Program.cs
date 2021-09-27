using System;

namespace _10_RectgleStarCenter
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());


            int numCols = n * 2;
            int numFilas;
            if (n % 2 == 0)
            {
                numFilas= n + 1;
            }
            else
            {
                numFilas = n + 2;
            }
            for (int filas = 0; filas < numFilas; filas++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (filas == 0 || filas == numFilas - 1)
                    {
                        Console.Write("%");
                    }
                    else if (col == 0 || col == numCols - 1)
                    {
                        Console.Write("%");

                    }
                    else if (filas == numFilas / 2 && (col == numCols / 2 || col == (numCols - 1) / 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
            
            
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
