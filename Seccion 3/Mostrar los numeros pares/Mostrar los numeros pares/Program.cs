using System;

namespace Mostrar_los_numeros_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\n///////////////////Listado de números pares entre rango///////////////////");
            Console.WriteLine("\n1-Ingrese dos numeros, el primero tiene que ser menor al segundo");
            Console.WriteLine("\n2-Mostrar los numeros pares");

            Console.WriteLine("\nIngrese el primer valor: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el segundo valor: ");
            int numero2 = int.Parse(Console.ReadLine());

            int i, c = 0;
            if (numero1 < numero2)
            {
                for (i = 1; i <= 2; i++)
                {

                    if (i % 2 == 0)
                    {
                        Console.WriteLine("\nLos números son pares");
                        c++;
                        Console.WriteLine("\nLa cantidad de numeros pares tipeados es: " +c);
                    }

                    
                }
            }
            else
            {
                Console.WriteLine("\nEl primer valor no es menor que el segundo cabeza de tuna");
            }

            Console.WriteLine("\t\n///////////////////Listado de números pares entre rango///////////////////");
            Console.WriteLine("\n1-Ingrese dos numeros, el primero tiene que ser menor al segundo");
            Console.WriteLine("\n2-Mostrar los numeros pares");

            Console.WriteLine("\nIngrese el primer valor: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el segundo valor: ");
            numero2 = int.Parse(Console.ReadLine());
            if (numero1 < numero2)
            {
                for (i = 1; i <= 2; i++)
                {

                    if (i % 2 == 0)
                    {
                        Console.WriteLine("\nEl numero es par");
                        c++;
                    }

                    Console.WriteLine("\nLa cantidad de numeros pares tipeados es: " + c);
                }
            }
            else
            {
                Console.WriteLine("\nEl primer valor no es menor que el segundo cabeza de tuna");
            }

        }
    }
}

