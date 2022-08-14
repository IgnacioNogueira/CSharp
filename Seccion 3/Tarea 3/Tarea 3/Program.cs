using System;

namespace Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {   /////////////////ejercicio 1//////////////////

            /*Console.WriteLine("\tTarea 3");
            Console.WriteLine("\nEjercicio 1");
            int i=1;

            while( i<=37 )
            {
                Console.WriteLine(i);
                i+=2;
            }

            Console.ReadLine();
            */

            //////////////////ejercicio 2////////////////

            /*Console.WriteLine("\tTarea 3");
            Console.WriteLine("\nEjercicio 2");
            Console.WriteLine("\nIngrese un número para calcularle su mitad: ");
            decimal numero =decimal .Parse (Console.ReadLine());
            decimal mitad=numero/2;
            Console.WriteLine("\nLa mitad del numero ingresado es: " + mitad);
            do
            {
                Console.WriteLine("\nIngrese un número para calcularle su mitad: ");
                numero = decimal.Parse(Console.ReadLine());
                mitad = numero / 2;
                Console.WriteLine("\nLa mitad del numero ingresado es: " + mitad);

            } while (numero>=0);

            Console.WriteLine("\nIngresó un valor negativo, FIN DEL PROGRAMA");

            Console.ReadLine();
            */

            //////////////////ejercicio 3//////////////////
            Console.WriteLine("\tTarea 3");
            Console.WriteLine("\nEjercicio 3");

            int i;
            int suma=0;
            Console.WriteLine("\nIngrese el primer valor: ");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el segundo valor: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el tercer valor: ");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el cuarto valor: ");
            int n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el quinto valor: ");
            int n5 = int.Parse(Console.ReadLine());
            suma = n1 + n2 + n3 + n4 + n5;
            Console.WriteLine("\nLa suma de los numeros es de: " + suma);

            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("\t\nTarea 3");
                Console.WriteLine("\nEjercicio 3");
                Console.WriteLine("\nIngrese el primer valor: ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nIngrese el segundo valor: ");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nIngrese el tercer valor: ");
                n3 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nIngrese el cuarto valor: ");
                n4 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nIngrese el quinto valor: ");
                n5 = int.Parse(Console.ReadLine());

                suma = n1 + n2 + n3 + n4 + n5;
                Console.WriteLine("\nLa suma de los numeros es de: " + suma);
            }

            Console.ReadLine();
        }
    }
}
