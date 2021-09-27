using System;

namespace _11_Increasing4Number
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count = 0;

           
            //}
            for (int i = a; i <= b; i++)
            {
                for (int j = i + 1; j <= b; j++)
                {
                    for (int k = j + 1; k <= b; k++)
                    {
                        for (int l = k + 1; l <= b; l++)
                        {
                          Console.WriteLine($"{i} {j} {k} {l}");
                            count++;
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }


            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
