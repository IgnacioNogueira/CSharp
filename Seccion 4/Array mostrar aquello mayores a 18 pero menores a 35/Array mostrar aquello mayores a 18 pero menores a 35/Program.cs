using System;

namespace Array_mostrar_aquello_mayores_a_18_pero_menores_a_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tMayores a 18, pero menores a 35");
            int[] numeros = { 31, 37, 34, 46, 20, 42 };
            Console.WriteLine("\nLa cadena muestra los siguientes numeros, pero la que cumple la condición es la siguiente"+numeros.Length);

            foreach (int numero in numeros)
             {
                 if (numero > 18 && numero < 35)
                 {

                    Console.WriteLine(numero);
                    Console.WriteLine("\nLa longitud es de : "+numeros.Length);

                }
             }
             
            Console.ReadLine();

        }
    }
}
