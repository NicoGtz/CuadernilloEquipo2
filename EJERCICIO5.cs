﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            //definir variables
            double costo, total;
            double cambio, descuento, dinero;
            //entrada
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("******TIENDA++++MINI SUPER ATLAPEXCO+++******");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("****insertar el precio del producto****");
            Console.ForegroundColor = ConsoleColor.White;
            costo = double.Parse(Console.ReadLine());

            if (costo >= 500)
            {
                descuento = costo * .15;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" El descuento es: $" + descuento);
                total = costo - descuento;
                Console.WriteLine(" El total es: $" + total);
            }
            else
                if (costo > 200 && costo < 500)
            {
                descuento = costo * .12;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" El descuento es: $" + descuento);
                total = costo - descuento;
                Console.WriteLine(" El total es: $" + total);
            }
            else
                if (costo <= 200)
            {
                descuento = costo * .1;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" El descuento es: $" + descuento);
                total = costo - descuento;
                Console.WriteLine(" El total es: $" + total);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("________GRACIAS POR SU COMPRA______");
            Console.ReadKey();
        }
    }
}