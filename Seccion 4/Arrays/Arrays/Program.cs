using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tArrays");
            string[] nombres = { "Pedro", "Maria", "Luis", "Benito", "Sabrina", "Lucho", "Josefina" };
            /* empieza el indice con el 0
            para buscar un nombre se haría:*/

            //nombres[3];
///////////////////////////////////////////////////////////////////////////////////////////////////////
            
            /*Para recorrer el array se usa el for:

            int nlongitud = nombres.Length; //para que el comp vea la longitud del array
            int i;

            for(i=0;i<nlongitud;i++)
            {
                Console.WriteLine(nombres[i]);

            }
            
            */

            //Hay una manera más fácil de recorrerlos:

            foreach(string nom in nombres) //se puede poner int si buscas enteros
            {
                Console.WriteLine(nom);
            }

            Console.ReadLine();
        }
    }
}
