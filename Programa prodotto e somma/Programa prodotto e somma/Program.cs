using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_prodotto_e_somma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("PROGRAMACION ESTRUCTURADA OYM 0463");
            Console.WriteLine("Sarah Lara           16-SIIT-1-073");
            Console.WriteLine("Aury Asencio         16-SIIT-1-074");
            Console.WriteLine("Walter Reynoso       16-SIIT-1-096");

            //DECLARACION DE VARIABLES Y CONVERSION ENTRE TIPO
            Console.ForegroundColor = ConsoleColor.Black;
            int h1, h2, h3, h4, h5 = 0;
            Console.WriteLine("INGRESE EL PRIMER VALOR  1");
            int.TryParse(Console.ReadLine(), out h1);
            Console.WriteLine("INGRESE EL SEGUNDO VALOR 2");
            int.TryParse(Console.ReadLine(), out h2);
            Console.WriteLine("INGRESE EL TERCER VALOR  3");
            int.TryParse(Console.ReadLine(), out h3);
            Console.WriteLine("INGRESE EL CUARTO VALOR  4");
            int.TryParse(Console.ReadLine(), out h4);
            Console.WriteLine("INGRESE EL QUINTO VALOR  5");
            int.TryParse(Console.ReadLine(), out h5);

            //HAREMOS LA SUMA DE LOS VALORES QUE EL USUARIO HA INSERTADO

            int sum = 0;
            sum = (h1 + h2 + h3 + h4 + h5);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("LA SUMA DIO COMO RESULTADO: " + sum.ToString());

            

            //CONDICION IF (1)

            if (sum <=100)
            {
                Console.WriteLine("FELICIDADES CUMPLES LA CONDICION");
            }
            else if (sum >=101)
            {
                Console.WriteLine("LAMENTABLEMENTE NO CUMPLES LA CONDICION, LA SUMATORIA NO ES IGUAL A 100");
            }

            //BLUCLE for DE POTENCIAS

            int p = 1;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" INTRODUCE LA POTENCIA A LA QUE QUIERES ELEVAR");
            int.TryParse(Console.ReadLine(), out p);

            for (int n = 1; n <= 15; n++) 
            {
                double m = Math.Pow(n, p);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(n + " ^ " + p + " = " + m );
            }


            //ENTRADA POR TECLADO
            string c;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("¿Le gustó el programa, profesor?");
            c = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("CIAO, SU RESPUESTA FUE: " +c);
            

            Console.ReadKey();

























        }
    }
}
