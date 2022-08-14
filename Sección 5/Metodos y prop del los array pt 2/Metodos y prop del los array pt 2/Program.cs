using System;

namespace Metodos_y_prop_del_los_array_pt_2
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] numeros = { 5, 18, 21, 4, 13 };

            int numero= Array.FindLast(numeros, p => p > 20);//nos devuelve el primer elemento, pero empieza a buscar de derecha a izq 

            Console.WriteLine("\nEl último elemento es: " + numero);

            Console.ReadLine();
        
        }
    }
}
