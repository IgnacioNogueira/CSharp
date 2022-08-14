using System;

namespace Tarea_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("\t\tTarea 4");
            Console.WriteLine("\nEjercicio 1");

            int[] valores = { 7, 9, 23, 56, 23, 34, 66, 78, 79, 34, 12, 16, 15 };
            int numerosPares = 0,numerosImpares=0;

            foreach(int num in valores)
            {
                if (num % 2 == 0)
                {
                    numerosPares++;
                }
                else
                {
                    numerosImpares++;
                }
            }
            Console.WriteLine("\nLa cantidad de numeros pares es de :" + numerosPares);
            Console.WriteLine("\nLa cantidad de numeros impares es de :" + numerosImpares);

            Console.ReadLine();
            */

            //////////////////ejercicio 2/////////////////////////////
            /*Console.WriteLine("\t\tTarea 4");
            Console.WriteLine("\nEjercicio 2");

            int[] valores = { 721, 9, 423, 56, 23, 34, 966, 78, 79, 3664, 12, 5516, 15 };
            int contCifras = 0;
            foreach (int num in valores)
            {
                if (num >= 100 && num <= 999)
                {
                    contCifras++;
                }
            }

            Console.WriteLine("\nLa cantidad de numeros positivos de 3 cifras es de: "+contCifras);
            Console.ReadLine();
            */

            //////////////////////ejercicio 3///////////////////////////

            Console.WriteLine("\t\tTarea 4");
            Console.WriteLine("\nEjercicio 3");
            int[] numeros = { 5, 8, 6, 4, 8, 25, 4, 2, 8, 12, 45, 12, 6, 7, 8 };
            int mayoresQuince = 0, sumaNumeros=0;
            foreach(int num in numeros)
            {
                if(num>15)
                {
                    sumaNumeros += num;
                }

            }

            Console.WriteLine("\nLa suma de los elementos que son mayores a 15 es de: " + sumaNumeros);
            Console.ReadLine();
        }
    }
}