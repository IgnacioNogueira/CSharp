using System;

namespace Ejercicio_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tEjercicio edad");

            Console.WriteLine("\nIngrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");

            }
            else
            {
                Console.WriteLine("Es menor de edad");

                Console.ReadLine();
            }
        }
    }
}
