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
                if (N % 2 == 0 && N % 2 ==0)
                {
                    if (N == STOP)
                    {
                        break;
                    }
                }
                //if (N % 3 == 0)
                //{

                //}
               
            }
            Console.WriteLine(N);

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
