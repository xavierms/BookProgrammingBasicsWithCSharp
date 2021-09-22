using System;

namespace _3_Stop_Sign
{
    class Program
    {
        static void Main()
        {
            Console.Write("#:");
            int n = int.Parse(Console.ReadLine());

            int puntos = n + 1;
            int midfila = 2 * n + 1;
            try
            {
                //se divide en 3
                //primera parte------------
                Console.WriteLine("{0}{1}{0}",
                    new string('.', n + 1),
                    new string('_', midfila));

                midfila -= 2;
                puntos--;

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("{0}//{1}\\\\{0}",
                        new string('.', puntos),
                        new string('_', midfila));

                    midfila += 2;
                    puntos--;
                }
                //segunda "media"-----------

                Console.WriteLine("//{0}STOP!{0}\\\\",
                    new string('_', (midfila - 5) / 2));

                //tercera "abajo"-------------
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("{0}\\\\{1}//{0}",
                        new string('.', i),
                        new string('_', midfila));

                    midfila -= 2;

                }

            }
            catch (Exception xx)
            {

                Console.WriteLine("El numero debe ser mayor de 1!", xx.Message);
            }
            

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
