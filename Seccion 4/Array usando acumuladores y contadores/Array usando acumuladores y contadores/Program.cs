using System;

namespace Array_usando_acumuladores_y_contadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tVideo 36 de arrays");

            int[] numeros = { 4, 5, - 4, 7, 8, -2, 12, 176, -6 };
            int contPositivos = 0, contNegativos = 0, sumaPositivos=0, sumaNegativos=0;
            foreach (int num in numeros) //recorre el array este foreach
            {
                Console.WriteLine("\nEn la cadena están los siguientes numeros: " + num);

                if (num >= 0)
                {
                    sumaPositivos += num;
                    contPositivos++;
                }
                else
                {
                    sumaPositivos += num;
                    contNegativos++;
                }
            }
            Console.WriteLine("\nLa cantidad de positivos es: " + contPositivos);
            Console.WriteLine("\nLa cantidad de negativos es: " + contNegativos);
            Console.WriteLine("\nLa suma de positivos es de: " + contPositivos);
            Console.WriteLine("\nLa suma de negativos es de: " + contPositivos);

            Console.WriteLine("\n////////////De prueba: ////////////////");
            Console.WriteLine("\nLa longitud de numeros es de: " + numeros.Length);
            Console.WriteLine("\nEn la posicion 03: " + numeros[3]);

             Console.ReadLine();

        }
    }
}
    