using System;

namespace FindIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 5, 18, 21, 22, 13 };

            int indice = Array.FindIndex(numeros, p => p > 10); //nos devuelve el primer elementos (en la posición que está), pero empieza a buscar de izq a derecha

            /* el findlastindex no encuentra lo mismo pero de derecha a izq */
            Console.WriteLine("\nEl indice es: " + indice);
            Console.WriteLine("\nSu valor es: " + numeros[indice]);

            Console.ReadLine();

        }
    }
}
