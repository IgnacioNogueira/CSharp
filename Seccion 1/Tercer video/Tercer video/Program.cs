using System;

namespace Tercer_video
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operaciones con cadenas");

            string cad1 = "ABC";
            string cad2 = "DEF";
            int numero = 20;
            char a = 'f';

            // string resultado= cad1*cad1 no se dividen, restan o multip

            string resultado = cad1+cad2; //pero si se suman
            string resultado2 = cad1 + numero; // tambien con cualquier otra cosa que definas

            Console.WriteLine(resultado); // no hace falta ponerlo en comillas
            Console.WriteLine(resultado2);
            Console.WriteLine("a"); //aca si se pone comillas
        }
    }
}
