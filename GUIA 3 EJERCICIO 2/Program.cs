using System;

namespace GUIA_3_EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *PROGRAMACION ESTRUCTURADA G07L
             *REBECA SARAÍ ALVARENGA HERNÁNDEZ
             *
             *EJERCICIO #2 GUIA 3
             */

            double b, h, a;
            Console.WriteLine("Hola y bienvenido :) Te solicitare solamente dos datos, la base y la altura.");
            Console.WriteLine("Empecemos con la base, ¿cual es la medida de la base?");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bien, ahora, ¿ cual es la medida de la altura?");
            h = Convert.ToDouble(Console.ReadLine());
            a = (b * h) / 2;
            Console.WriteLine("\nEl area del triangulo propuesto es de " + a);
            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa...");
            Console.ReadKey();
        }
    }
}
