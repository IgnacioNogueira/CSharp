using System;

namespace Métodos_de_los_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero = "15"; //si pones "ab" va a lanzar false porque no es un número
                                                /*  -Int 16=short
                                                    -Int 32=int
                                                    -Int 64=long
                                               */
            int resultado;
            bool exito = Int32.TryParse(numero, out resultado);
            int suma = resultado + 5;
            Console.WriteLine("La suma es: " + suma);
                                                                 /*-tryparse es para convertir un string en un entero
                                                                   -out es donde se va a guardar
                                                                   -Te devuelve true o false si se puede convertir*/
          //////////////Esto para saber si se puede convertir una cadena en números////////////
            /*if(exito ==true)
            {
                Console.WriteLine("\nEs un número");
            }
            else
            {
                Console.WriteLine("\n No es un número");

            }
            */



            Console.ReadLine();
        }
    }
}
