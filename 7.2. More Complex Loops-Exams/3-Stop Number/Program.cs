using System;

namespace _3_Stop_Number
{
    class Program
    {
        static void Main()
        {
            int N    = int.Parse(Console.ReadLine());
            int M    = int.Parse(Console.ReadLine());
            int STOP = int.Parse(Console.ReadLine());

            for (int i = M; i >= N; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == STOP)
                    {
                       
                        break;
                    }

                    Console.Write(i  + ", ");
                   
                }

               
            }
            

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
