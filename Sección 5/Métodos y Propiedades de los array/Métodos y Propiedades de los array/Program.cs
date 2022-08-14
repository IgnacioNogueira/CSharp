using System;

namespace Métodos_y_Propiedades_de_los_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 5, 18, 21, 4, 13 };
            string[] nombres = { "Pedro", "Luis", "José", "Felipe" };

            /*
            //sacar el primer elementos del array que sea mayor a 15

            int mayorA15 = Array.Find(numeros, p => p > 15); // el p=> recorre el array y después se pone la condicion de izq a derecha
            int[] numerosFiltrados = Array.FindAll(numeros, el => el > 15); //nos devuelve un string con los numeros

            Console.WriteLine("\nEl primer elemento mayor a 15 es: " + mayorA15);


            foreach (int el in numerosFiltrados)
            {
                Console.WriteLine("\nLos valores mayores a 15 son: " + el);
            }

            */

            int indice= Array.IndexOf(numeros, 4); // devuelve valores enteros

            if (indice >0) //significa que está en el array
            {
                Console.WriteLine("\nExiste el valor en la posición: " +indice);
            }
            else
            {
                Console.WriteLine("\nNo existe el valor: ");
            }

            Console.ReadLine();
        }
    }
}
