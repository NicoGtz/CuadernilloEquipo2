using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2_CUADERNILLO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DECLARAR VARIABLES 
            double PDP, PD = 0, DES = 0;

            Console.WriteLine("COSTO Y DESCUENTO DE UN MUEBLE");
            Console.WriteLine("INGRESA EL PRECIO DEL MUEBLE");
            PDP = double.Parse(Console.ReadLine());

            //proceso

            if (PDP <= 0)
            {
                Console.WriteLine("VERIFICACION DEL PRECIO");
                Console.ReadKey();
            }
            else
            if (PDP >= 3900)
            {
                DES = PDP * 0.25;
                PD = PDP - DES;
            }
            else
                if (PDP > 3800 && PDP < 3900)
            {
                DES = PDP * 0.20;
                PD = PDP - DES;
            }


            else
                if (PDP <= 3800 && PDP >= 1)
            {
                DES = PDP * 0.15;
                PD = PDP - DES;
            }

            Console.WriteLine("EL DESCUENTO DE LA PUERTA ES: " + DES);
            Console.WriteLine("EL PRECIO CON DESCUENTO ES: " + PD);
            Console.ReadKey();
        }
    }
}
