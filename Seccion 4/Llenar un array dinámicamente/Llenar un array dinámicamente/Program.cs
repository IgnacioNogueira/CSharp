using System;

namespace Llenar_un_array_dinámicamente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tLlenar un array dinámicamente");

            int i;
            int[] numeros = new int[4];

            for(i=0;i<4;i++) // no puede ser igual a 4 porque no llega a 4
            {
                Console.WriteLine("Ingrese numero " + (i + 1)); // porque sino empezaría con ingrese numero 0
                numeros [i] =int .Parse(Console.ReadLine()); //acá va a almacenar los numeros que digites

            }

            int suma = numeros[0] + numeros[3];
            Console.WriteLine("La Suma: " + suma);
            
            foreach(int num in numeros )
            {
                Console.WriteLine("\n.Los valores asignados son: "+num);
            }
            
            Console.ReadLine();
        }
    }
}
