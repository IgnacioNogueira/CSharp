using System;

namespace Sección_2__inicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer valor: ");
            decimal numeroentero= decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el primer valor: ");
            decimal numeroentero2 = decimal.Parse(Console.ReadLine());

            if (numeroentero>numeroentero2)
            {
                Console.WriteLine("El primer número es mayor");

            }
            else
            {
                Console.WriteLine("El segundo número es mayor");
            }


        }
    }
}
