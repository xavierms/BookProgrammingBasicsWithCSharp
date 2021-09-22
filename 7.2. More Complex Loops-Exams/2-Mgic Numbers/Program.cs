using System;

namespace _2_Mgic_Numbers
{
    class Program
    {
        static void Main()
        {
           int magic = int.Parse(Console.ReadLine());


            for (int d1 = 0; d1 <= 9; d1++)
            {
                for (int d2 = 0; d2 <= 8; d2++)
                {
                    for (int d3 = 0; d3 <= 7; d3++)
                    {
                        for (int d4 = 0; d4 <= 6; d4++)
                        {
                            for (int d5 = 0; d5 <= 5; d5++)
                            {
                                for (int d6 = 0; d6 <= 4; d6++)
                                {
                                    int re = d1 * d2 * d3 * d4 * d5 * d6;
                                    if (re == magic)
                                    {
                                        Console.WriteLine("{0}{1}{2}{3}{4}{5}", d1, d2, d3, d4, d5, d6);
                                    }
                                }
                            }
                        }
                    }
                }
            }


            //int d1 = 0;
            //int d2;
            //int d3=0;
            //int d4;
            //int d5;
            //int d6;

            //while (d1 <= 9)
            //{
            //     d2 = 0;
            //    while (d3 <= 9)
            //    {
            //        d3 = 0;
            //        while (d3 <= 9)
            //        {
            //            d4 = 0;
            //            while (d3 <= 9)
            //            {
            //                d5 = 0;
            //                while (d3 <= 9)
            //                {
            //                    d6 = 0;
            //                    while (d3 <= 9)
            //                    {
            //                        if (d1 * d2 * d3 * d4* d5*d6)
            //                        {
            //                            Console.WriteLine("{0}{1}{2}{3}{4}{5}",d1,d2,d3,d4,d5,d6);
            //                        }
            //                    d6++;
            //                    }
            //                d5++;
            //                }
            //            d4++;
            //            }
            //        d3++;
            //        }
            //    d2++;
            //    }
            //  d1++;
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
