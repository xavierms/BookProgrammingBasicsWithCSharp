using System;

namespace _12_GeneratingRectang
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int count = 0;

            for (int left = -n; left < n; left++)
            {
                for (int top = -n; top < n; top++)
                {
                    for (int right = left + 1; right <= n; right++)
                    {
                        for (int bottom = top + 1; bottom <= n; bottom++)
                        {
                            int area = Math.Abs(right - left) * Math.Abs(bottom - top);
                            if (area >= m)
                            {
                                Console.WriteLine($"({left}, {top}) {right}, {bottom})->  {area}");
                                count++;
                            }
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
