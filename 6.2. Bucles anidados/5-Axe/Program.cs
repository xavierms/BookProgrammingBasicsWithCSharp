using System;

namespace _5_Axe
{
    class Program
    {
        static void Main()
        {
            Console.Write("#:");
            int n = int.Parse(Console.ReadLine());

            int ancho     = 5 * n;
            int izquierdo = 3 * n;
            int mid       = 0;
            int derecha   = ancho - izquierdo - mid - 2;


            try
            {
                //1-----
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("{0}*{1}*{2}",
                        new string('-', izquierdo),
                        new string('-', mid),
                        new string('-', derecha));
                    mid++;
                    derecha--;
                }
                //2-----mango del hacha
                mid--;
                derecha++;
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{2}",
                        new string('*', izquierdo),
                        new string('-', mid),
                        new string('-', derecha));
                }
                //3-----abajo

                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{2}",
                        new string('-', izquierdo),
                        new string('-', mid),
                        new string('-', derecha));

                    izquierdo--;
                    derecha--;
                    mid += 2;
                }
                Console.WriteLine("{0}*{1}*{2}",
                        new string('-', izquierdo),
                        new string('*', mid),
                        new string('-', derecha));

            }
            catch (Exception xx)
            {

                Console.WriteLine("No puede ser 0!", xx.Message);
            }
            
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
