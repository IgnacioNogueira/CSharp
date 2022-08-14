using System;

namespace Ejercicio_while_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tBienvenido!");
            Console.WriteLine("\n--------El numero puede ser para o impar, tiene que ser != 0--------");
            Console.WriteLine("\nIngrese un numero:");
            int numero =int.Parse(Console.ReadLine());

            if (numero % 2 == 0 && numero >=0)
            {
                Console.WriteLine("\n-El numero es par");
            }
            else if (numero >= 0)
            {
                Console.WriteLine("\n-El numero es impar");
            }
            while(numero>=0)
            {
                Console.WriteLine("\n--------El numero puede ser para o impar, tiene que ser != 0--------");
                Console.WriteLine("\nIngrese un numero:");
                numero = int.Parse(Console.ReadLine());

                if (numero%2 == 0 && numero >= 0)
                {
                    Console.WriteLine("\n-El numero es par");
                }
                else if(numero >= 0)
                {
                    Console.WriteLine("\n-El numero es impar");
                }
            }

            Console.WriteLine("\nEl numero es negativo, error");
            Console.ReadLine();
        }
    }
}
