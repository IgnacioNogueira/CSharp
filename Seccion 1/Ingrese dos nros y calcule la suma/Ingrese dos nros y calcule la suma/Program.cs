using System;

namespace Ingrese_dos_nros_y_calcule_la_suma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tIngrese Dos numeros y de el resultado de su suma");

            Console.WriteLine("\nIngrese el primer número: ");
            string numero1 = Console.ReadLine(); /*Se usa tambien como el scanf de c
                                                 te devuelve una cadena de string
                                                 como un printf*/

            Console.WriteLine("\nIngrese el segundo número: ");
            string numero2= Console.ReadLine();

            int numero1Convertido = int.Parse(numero1);
            int numero2Convertido = int.Parse(numero2);
            int suma = numero1Convertido + numero2Convertido;

            Console.WriteLine("\n1-El primer numero ingresado es: " + numero1);
            Console.WriteLine("\n2-El segundo numero ingresado es: " + numero2);
            Console.WriteLine("\n3-La suma de los dos numeros es: " + suma);


            Console.ReadLine();
        }

        }
    }
