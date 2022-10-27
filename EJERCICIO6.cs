using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            //definir variables
            char sexo;
            int edad, opcion;
            //entrada
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("***** REALIZA LA SIGUINETE TEST PARA IDENTIFICAR QUE TANTO SABES DE LA COMPUTACION *****");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  EDAD: ");
            Console.ForegroundColor = ConsoleColor.White;
            edad = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("INSERTAR SEXO (m=masculino y f=femenino):  ");
            Console.ForegroundColor = ConsoleColor.White;
            sexo = char.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*****SELECCIONA LA OPCION CORRECTA*****");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("_____A-¿SON LOS COMPONENTES INTERNOS DE UNA COMPUTADORA?____");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("     1-Teclado,Mouse, Monitor");
            Console.WriteLine("     2-Impresora, Bocinas, USB");
            Console.WriteLine("     3-Fuente de poder, Tarjeta madre, Memoria RAM");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*****SELECCIONA LA OPCION CORRECTA*****");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1 || opcion == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("incorrecto");

            }
            if (opcion == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("correcto");
            }
              
            int opcion1;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*****SELECCIONA LA OPCION CORRECTA*****");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("B-¿LA COMBINACION DE TECLAS CTRL + X ME PERMITE?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  1-cortar");
            Console.WriteLine("  2-copiar");
            Console.WriteLine("  3-borrar");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*****SELECCIONA LA OPCION CORRECTA*****");
            opcion1 = int.Parse(Console.ReadLine());

            if (opcion1 == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("correcto");
            }
            if (opcion1 == 2 || opcion1 == 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("incorrecto");
            }
            Console.ReadLine();
            char opcion2;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*****SELECCIONA LA OPCION CORRECTA*****");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("____C-¿QUE COMPONENTES PERMITEN ALMACENAR DATOS?____");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  1-Teclado y raton o mause");
            Console.WriteLine("  2-Monitor");
            Console.WriteLine("  3-La a y b");
            Console.WriteLine("  4-Unidades de almacenamineto");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*****SELECCIONA LA OPCION CORRECTA*****");
            opcion2 = char.Parse(Console.ReadLine());

            if (opcion2 == '1' || opcion2 == '2' || opcion2 == '3' || opcion2 == '4')
            {
                switch (opcion2)
                {
                    case '1':
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("incorrecta");

                        break;
                    case '2':
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("incorrecta");

                        break;
                    case '3':
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("incorrecta");

                        break;
                    case '4':
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("correcta");

                        break;
                }
            }
            Console.ReadKey();
            char opcion3;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*****SELECCIONA LA OPCION CORRECTA*****");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("____D-¿QUE COVINACION DE TECLAS ME PERMITE PEGAR EL CONTENIDO COPIADO____");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   1-CONTROL V");
            Console.WriteLine("   2-CONTROL Z");
            Console.WriteLine("   3-CONTROL P");
            Console.WriteLine("   4-CONTROL SHIFT");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*****SELECCIONA LA OPCION CORRECTA*****");
            opcion3 = char.Parse(Console.ReadLine());

            if (opcion3 == '1' || opcion3 == '2' || opcion3 == '3' || opcion3 == '4')
            {
                switch (opcion3)
                {
                    case '1':
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("correcta");

                        break;
                    case '2':
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("incorrecta");

                        break;
                    case '3':
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("incorrecta");

                        break;
                    case '4':
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("incorrecta");

                        break;
                }
            }
            Console.ReadKey();
            int opcion4;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*****SELECCIONA LA OPCION CORRECTA*****");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("____E-¿CUALES SON LAS PARTES DE LA COMPUTADORA?____");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   1-Teclado, mesa, silla");
            Console.WriteLine("   2-Puerta, monitor y mouse");
            Console.WriteLine("   3-CPU, monitor, teclado y mouse");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*****SELECCIONA LA OPCION CORRECTA*****");

            opcion4 = int.Parse(Console.ReadLine());

            if (opcion4 == 1 || opcion4 == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("incorrecto");
            }
            if (opcion4 == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("correcto");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("******GRACIAS POR SU TIEMPO******");
            }

            Console.ReadKey();
            
        }
    }
}
