using System;

namespace _2_Christmas_Tree
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var star = new string('*', i);
                var spaces = new string(' ',  n - i);

                Console.Write(spaces);
                Console.Write(star);
                Console.Write('|');
                Console.Write(star);
                Console.WriteLine(spaces);
            }

            //Detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
