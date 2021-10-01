using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Five_Special_Letters
{
    class Program
    {
        static void Main()
        {

            int comenzar = int.Parse( Console.ReadLine() );
            int final    = int.Parse( Console.ReadLine() );

            bool dicerNo = true;
           
            var pesoLetras = new Dictionary<int, KeyValuePair<char, int>>()
            {
                 {0 , new KeyValuePair<char, int> ('a', 5 ) },
                 {1 , new KeyValuePair<char, int> ('b',-12 ) },
                 {2 , new KeyValuePair<char, int> ('c', 47 ) },
                 {3 , new KeyValuePair<char, int> ('d', 7 ) },
                 {4 , new KeyValuePair<char, int> ('e', -32  ) },
               
            };
            //En GetAObtiene el primer valor que es 'a', y de dice que 'Key:5' sea == a 'a' y que obtenga su valor que es 5 y asi en todos los casos.
            //var GetA = pesoLetras.First(a => a.Key == 'a').Value;
            //var GetB = pesoLetras.First(a => a.Key == 'b').Value;
            //var GetC = pesoLetras.First(a => a.Key == 'c').Value;
            //var GetD = pesoLetras.First(a => a.Key == 'd').Value;
            //var GetE = pesoLetras.First(a => a.Key == 'e').Value;

            int formula = 0;
            //foreach (KeyValuePair<char, int> item in pesoLetras)
            //{
            //    Console.WriteLine(" = {0},{1}", item.Key, item.Value);
            //}

            for (int i1 = 0; i1 < 5; i1++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    for (int i3 = 0; i3 < 5; i3++)
                    {
                        for (int i4 = 0; i4 < 5; i4++)
                        {
                            for (int i5 = 0; i5 < 5; i5++)
                            {
                             

                               // var pesoletrasSinRepetidas = pesoLetras.Distinct().ToList();
                                List<int> distinctP = new List<int>();
                                distinctP.Add(pesoLetras.First(a => a.Key == i1).Value.Value);
                                distinctP.Add(pesoLetras.First(a => a.Key == i2).Value.Value);
                                distinctP.Add(pesoLetras.First(a => a.Key == i3).Value.Value);
                                distinctP.Add(pesoLetras.First(a => a.Key == i4).Value.Value);
                                distinctP.Add(pesoLetras.First(a => a.Key == i5).Value.Value);

                                 var result = 0;
                                 int count = 1;

                                foreach (var items in distinctP.Distinct() )
                                {
                                    result += (count ) * items;
                                    count++;
                                }

                                //formula = (1 * pesoLetras.First(a => a.Key == i1).Value.Value) +
                                //              (2 * pesoLetras.First(a => a.Key == i2).Value.Value) +
                                //              (3 * pesoLetras.First(a => a.Key == i3).Value.Value) +
                                //              (4 * pesoLetras.First(a => a.Key == i4).Value.Value) + 
                                //              (5 * pesoLetras.First(a => a.Key == i5).Value.Value);


                                if (result >= comenzar && result <= final)
                                {
                                    Console.WriteLine($"{ pesoLetras.First(a => a.Key == i1).Value.Key}{pesoLetras.First(a => a.Key == i2).Value.Key}{pesoLetras.First(a => a.Key == i3).Value.Key }{pesoLetras.First(a => a.Key == i4).Value.Key}{pesoLetras.First(a => a.Key == i5).Value.Key}");
                                    dicerNo=false;
                                }

                                
                            }
                        }
                    }
                }
            }


            if (dicerNo)
            {
                Console.WriteLine("No");
            }

            //Console.WriteLine(count);

            Console.ReadKey();
            Console.Clear();
            Main();

        }
    }
}
