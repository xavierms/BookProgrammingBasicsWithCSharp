using System;
using System.Collections.Generic;

namespace _1_Crossing_Sequences
{
    class Program
    {
        static void Main()
        {
            int tribonacciFIrts  = int.Parse(Console.ReadLine());
            int tribonacciSecond = int.Parse(Console.ReadLine());
            int tribonacciThird  = int.Parse(Console.ReadLine());
            int spiralCurrent    = int.Parse(Console.ReadLine());
            int spiralStep       = int.Parse(Console.ReadLine());

            var tribonacciNumbers = new List<int>()
            {
                tribonacciFIrts,
                tribonacciSecond,
                tribonacciThird 
            };
            var tribonacciCurrent = tribonacciThird;

            while (tribonacciCurrent < 1000000)
            {
                tribonacciCurrent = tribonacciFIrts + tribonacciSecond + tribonacciThird;

                tribonacciNumbers.Add(tribonacciCurrent);

                tribonacciFIrts = tribonacciSecond;
                tribonacciSecond = tribonacciThird;
                tribonacciThird = tribonacciCurrent;
            }
            var spiralNumbers = new List<int>() { spiralCurrent };
            var spiralCount   = 0;
            var spiralStepMul = 1;

            while (spiralCurrent < 1000000)
            {
                spiralCurrent += spiralStep * spiralStepMul;

                spiralNumbers.Add(spiralCurrent);
                spiralCount++;

                if (spiralCount % 2 == 0)
                {
                    spiralStepMul++;
                }
            }

            var found = false;
            for (int i = 0; i < tribonacciNumbers.Count; i++)
            {
                for (int j = 0; j < spiralNumbers.Count; j++)
                {
                    if (tribonacciNumbers[i] == spiralNumbers[j] && tribonacciNumbers[i] <= 1000000)
                    {
                        Console.WriteLine();
                        Console.WriteLine(tribonacciNumbers[i]);
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("No");
            }



            Console.ReadKey();
            Console.Clear();
            Main();
            }
    }
}
