using System;

namespace _2__Max_Number
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("**Número máximo** \n");
            Console.Write("Numero: ");
            int loop = int.Parse(Console.ReadLine());

            var max = int.MinValue;
            for (int i = 1; i <= loop; i++)
            {
                int num = int.Parse( Console.ReadLine() );

                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("Max :" + max);


            //Detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
