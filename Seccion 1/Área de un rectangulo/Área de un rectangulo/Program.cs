using System;

namespace Área_de_un_rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tArea de un triangulo");

            Console.WriteLine("\n Ingrese la base del triangulo: ");
            int Basetriang =int.Parse(Console.ReadLine()); //Hago la conversion directa porque sino te devuelve strings

            Console.WriteLine("\n Ingrese la altura del triangulo: ");
            int Alttriang= int.Parse(Console.ReadLine());


            int Area = Basetriang * Alttriang;

            Console.WriteLine("\n El area del triangulo es: "+ Area);

            Console.ReadLine();
        }
    }
}
