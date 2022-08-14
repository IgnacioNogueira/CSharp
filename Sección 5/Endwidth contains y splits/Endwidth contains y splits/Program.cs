using System;

namespace Endwidth_contains_y_splits
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string apellido= "Roman";
            string Nombre= "Riquelme ";

            if(apellido.EndsWith('n'))
            {
                Console.WriteLine("\nTermina con n");
                string ultLetra = apellido.Substring(apellido.Length - 1, 1);
                Console.WriteLine("\nTermina con la letra " + ultLetra + " (verificación)");
            }
            else
            {
                
                Console.WriteLine("\nNo termina con n");
            }
            //////////////////////////////Prueba////////////////////////////////////////
            
            Console.WriteLine("\nLa cantidad de caracteres que tiene el nombre es de: " + Nombre.Trim().Length);
            */
        
            /*string mensaje = "Me fui a comprar al chino";
            if(mensaje.Contains("fui"))
            {
                Console.WriteLine("Sí lo contiene");
            }
            else
            {
                Console.WriteLine("No lo contiene");
            }

               */

            string palabra = "Cartuchera";
            string[] array = palabra.Split('a'); /*nos devuelve un array de string
                                                    -separa el string en la letra que marcas
                                                    -Me devolvió: C //////rtucher*/

            foreach(string item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

    }
}
