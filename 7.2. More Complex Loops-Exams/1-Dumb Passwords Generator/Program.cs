using System;

namespace _1_Dumb_Passwords_Generator
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int I = int.Parse(Console.ReadLine());


            for (int d1 = 1; d1 <= n; d1++)
            {
                for (int d2 = 1; d2 <= n; d2++)
                {
                    for (var c1 = 'a'; c1 <'a' +I; c1++)
                    {
                        for (var c2 = 'a'; c2 < 'a' + I; c2++)
                        {
                            for (int d3 = Math.Max(d1,d2) + 1; d3 <= n; d3++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", d1,d2,c1,c2,d3);
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }


            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
