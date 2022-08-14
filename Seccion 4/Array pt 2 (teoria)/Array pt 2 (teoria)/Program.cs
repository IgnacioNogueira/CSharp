using System;

namespace Array_pt_2__teoria_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tArrays (Teoría)");

            string[] nombres = { "Pepe", "Juan", "Julio" };
            Console.WriteLine("\nEl número de elementos es de: " + nombres.Length);
            Console.WriteLine("\nEl primer nombre es: " + nombres[0]);
            Console.WriteLine("\nEl último nombre es: " + nombres[2]); //siempre contar un elemento menos de los que hay
            Console.WriteLine("\nEl último con truquito es: " + nombres[nombres.Length - 1]); //esto para siempre averiguar el último
           
            Console.ReadLine();
        }
    }
}
