using System;

namespace _5_Integer_to_Base
{
    class Program
    {
        static void Main()
        {
            var numeroUno = int.Parse(Console.ReadLine());
            var numeroDos = int.Parse(Console.ReadLine());

            IntegerToBase(numeroUno, numeroDos);
        }

        static void IntegerToBase(int numeroUno, int numeroDos)
        {
            int segundoDigito = numeroUno % numeroDos;
            int cociente      = numeroUno / numeroDos;
            int primerDigito  = cociente  % numeroDos;

            Console.WriteLine($"{primerDigito}{segundoDigito}");
        }
    }
}
