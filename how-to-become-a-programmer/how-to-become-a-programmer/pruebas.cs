using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace how_to_become_a_programmer
{
    public class pruebas
    {
        public pruebas()
        {
        int paciente = 10;

        Console.WriteLine("insertar sentencia: ",paciente);
        paciente = Int32.Parse(Console.ReadLine());
        if (paciente > 10)
        {
            Console.Beep(850, 700);
            Console.Beep(850, 700);
            Console.Beep(850, 700);
            Console.Beep(850, 700);
            Console.Beep(850, 700);
        }
        else
        {
            Console.Beep(850, 700);
            Console.Beep(850, 700);
            Console.Beep(850, 70000);
        }

        }
    }
}
