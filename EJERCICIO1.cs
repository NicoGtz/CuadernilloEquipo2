using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_1_CUADERNILLO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES

            double L, A, PXC, PT;
       
            //ENTRADA

            Console.WriteLine("CALCULAR EL PRECIO DE UN TABLON");
            Console.WriteLine("INGRESA EL LARGO DEL TABLON");
            L = double.Parse(Console.ReadLine());
            Console.WriteLine("INGRESA EL ANCHO DEL TABLON");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("INGRESA EL PRECIO POR CENTIMETRO");
            PXC = double.Parse(Console.ReadLine());

            //PROCESO

            PT = (L * A) * PXC;
            Console.WriteLine("EL PRECIO DE LA TABLA ES: " + PT);
            Console.ReadKey();     
        }
    }
}
