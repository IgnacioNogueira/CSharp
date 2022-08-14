using System;

namespace Ejercicio_descuento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tEjercicio descuento");
            
            Console.WriteLine("\nIngrese el valor del precio: ");
            decimal precio=decimal.Parse(Console.ReadLine());
            decimal descuento = precio * 0.20m;
            decimal ResultadoDescuento = precio-descuento;

            Console.WriteLine("\nEl descuento es: "+descuento);
            Console.WriteLine("\nEl precio final queda: " + ResultadoDescuento);


            Console.ReadLine();

        }
    }
}
