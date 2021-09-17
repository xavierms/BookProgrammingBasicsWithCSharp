using System;

namespace _5_Hotel_Room
{
    class Program
    {
        static void Main()
        {
            var mes_instancia    = Console.ReadLine().ToLower();
            double numero_instancia =double.Parse( Console.ReadLine() );

            double studio = 0;
            double apart  = 0;
            double totalEstudio = 0.00;
            double totaltApart = 0;
           
            switch (mes_instancia)
            {
                case "mayo":
                    studio = 50;
                    apart = 65;
                    break;case "junio":
                    studio = 75.20;
                    apart = 68.70;
                    break;case "julio":
                    studio = 76;
                    apart = 77;
                    break;case "agosto":
                    studio = 76;
                    apart = 77;
                    break;case "septiembre":
                    studio = 75.20;
                    apart = 68.70;
                    break;case "octubre":
                    studio = 50;
                    apart = 65;
                    break;
                default:
                    break;
            }

            if (numero_instancia >= 7 && numero_instancia <= 14 && mes_instancia.Equals("mayo") || mes_instancia.Equals("octubre") )
            {
                totalEstudio =  (studio - (studio * 0.05)) * numero_instancia;
                
            }
            else if (numero_instancia >= 14  && mes_instancia.Equals("mayo") || mes_instancia.Equals("octubre"))
            {
                totalEstudio = (studio - (studio * 0.30)) * numero_instancia;
                totaltApart  = (apart - (apart * 0.10)) * numero_instancia;
            }
             if (numero_instancia > 14 && mes_instancia.Equals("junio") || mes_instancia.Equals("septiembre"))
            {
               
                totalEstudio = (studio - (studio * 0.20)) * numero_instancia;
                totaltApart = (apart - (apart * 0.10)) * numero_instancia;
            }
            else if (numero_instancia <= 14)
            { 
                totalEstudio = studio * numero_instancia;
                totaltApart = apart * numero_instancia;
            }
            else if (numero_instancia >= 14 && mes_instancia.Equals("julio") || mes_instancia.Equals("agosto"))
            {
                totalEstudio = studio * numero_instancia;
                totaltApart = (apart - (apart * 0.10)) * numero_instancia;
            }

            Console.WriteLine("Apartamento: {0} \n Estudio: {1}", totaltApart, totalEstudio);
            //detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
