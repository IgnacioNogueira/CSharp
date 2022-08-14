using System;

namespace Tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////Punto 1///////

        /*Console.WriteLine("\tTarea 01");
        Console.WriteLine("\nEjercicio 1: ");

         Console.WriteLine("\nIngresar el numero de semanas: ");
         int Semanas = int.Parse(Console.ReadLine());

        int TotalDias = (Semanas * 7) / 1;

        Console.WriteLine("Convertido a días es: " + TotalDias);

        Console.ReadLine();*/

        /////Punto 2/////

        /*Console.WriteLine("\tTarea 01");
        Console.WriteLine("\nEjercicio 2: ");

        Console.WriteLine("\nIngrese las horas que trabaja el empleado: ");
        int Horastrabajadas=int.Parse(Console.ReadLine());

        int valor = Horastrabajadas * 20;

        Console.WriteLine("\nEl sueldo del empleado en soles es de: " + valor);

        Console.ReadLine();*/

        /////Punto 3/////
         Console.WriteLine("\tTarea 01");
         Console.WriteLine("\nEjercicio 3: ");

         Console.WriteLine("\nIngrese el valor del producto: ");
            decimal Valorproduc= decimal.Parse(Console.ReadLine());

            decimal aumento = Valorproduc * 0.18m;
            decimal Resultadofinal = Valorproduc + aumento;

            Console.WriteLine("\nEl IGV es de: " + aumento);
            Console.WriteLine("\nEl total del precio con el aumento es: " + Resultadofinal);

            Console.ReadLine();
        }
    }
}
