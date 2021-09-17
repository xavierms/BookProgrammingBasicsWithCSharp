using System;

namespace _3_Min_Number
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("**Número máximo** \n");
            Console.Write("Numero: ");
            int loop_ = int.Parse(Console.ReadLine());

            int numerosIzquierda = 0;
            int numerosDerecha   = 0;
            for (int loop1 = 1; loop1 <= loop_; loop1++)
            {                
              numerosIzquierda = numerosIzquierda + int.Parse(Console.ReadLine());                
            }
            for (int loop2 = 1; loop2 <= loop_; loop2++)
            {
                numerosDerecha = numerosDerecha + int.Parse(Console.ReadLine());
            }
            if (numerosIzquierda == numerosDerecha)
            {
                Console.WriteLine("Sí, suma = {0}", numerosIzquierda);
            }
            else
            {
                var diferencia = Math.Abs(numerosDerecha - numerosIzquierda);
                Console.WriteLine("No, la diferencia es = {0}", diferencia);
            }


            //Detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
