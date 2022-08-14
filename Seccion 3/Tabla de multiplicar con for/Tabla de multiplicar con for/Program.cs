using System;

namespace Tabla_de_multiplicar_con_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tTabla del 2");

            int i;
            Console.WriteLine("\ningrese un valor para la tabla: ");
            int numero = int .Parse(Console.ReadLine());
           
            for (i=1;i<=numero;i++)
            {
                int resultado = 2 * i;
                Console.WriteLine("2 x " +i +"="+resultado);
               
            }

            Console.ReadLine();
        }
    }
}
