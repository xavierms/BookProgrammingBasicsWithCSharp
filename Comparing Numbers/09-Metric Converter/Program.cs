using System;
using System.Collections;
using System.Collections.Generic;

namespace _09_Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {



            List<Metrics> metrics = new List<Metrics>()
            {
                new Metrics()
                {
                    unit = "mm",
                    number = 1000
                },
                new Metrics()
                {
                    unit = "cm",
                    number = 100
                },new Metrics()
                {
                    unit = "mi",
                    number = 0.000621371192
                },
                new Metrics()
                {
                    unit = "in",
                    number = 39.3700787
                },
                new Metrics()
                {
                    unit = "km",
                    number = 0.001
                },
                new Metrics()
                {
                    unit = "ft",
                    number = 3.2808399
                },
                new Metrics()
                {
                    unit = "yd",
                    number = 1.0936133
                }
            };

            Console.Write("Insert number to convert:  ");
            var number = double.Parse( Console.ReadLine());

            Console.Write("Insert unit to convert:  ");
            var sourceMetric = Console.ReadLine();

            Console.Write("Insert unit to convert:  ");
            var destMetric = Console.ReadLine();

            var result1 = metrics.Find(x => x.unit == sourceMetric);
            var result2 = metrics.Find(x => x.unit == destMetric);
            
                var result = (number / result1.number) * result2.number;

                Console.WriteLine("Result: " + result);
           
           
        }
        class Metrics
        {
            public string unit { get; set; }
            public double number { get; set; }

        }
    }
}
