using System;

namespace Convertir_tipo_de_dato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tConversion de datos");

            int a = 30;
            string cadena = a.ToString();

            Console.WriteLine(a); //De entero,decimal,double,etc a cadena: .ToString

            ///////////////////////////////////////////////////////////////////////
            /*string numero = "20";

            int numeroConvertido= int.Parse(numero); // para convertir de string a entero o decimal, double, como quieras



            string resultado= numero + 10; //se suma la cadena y el numero, no se mezcla (no da 30)

            int resultado2 = numeroConvertido + 10; //fijarse para ponerlo en entero, si se deja string, está mal

            Console.WriteLine("\n1.Suma " + resultado);
            Console.WriteLine("\n2.La conversion de cadena a entero es:  " + resultado2);

            */

            /////////////////////////////////////////////////////////////////////
            /*string cad1 = "ABC";
            string cad2 = "DEF";
            int numero = 20;
            char a = 'f';

            // string resultado= cad1*cad1 no se dividen, restan o multip

            string resultado = cad1 + cad2; //pero si se suman
            string resultado2 = cad1 + numero; // tambien con cualquier otra cosa que definas

            Console.WriteLine(resultado); // no hace falta ponerlo en comillas
            Console.WriteLine(resultado2);
            Console.WriteLine("a"); //aca si se pone comillas
            */
        }
    }
}
