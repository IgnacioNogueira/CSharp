using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tHello World!");

            string pasaporte = "12345678";
            string nombre = "Pepe lucho"; //cómo obtengo una porcion de esa cadena?

            string pasT= pasaporte.Substring(0, 3); //(*1,*2) *1:es la posición *2: es la cantidad que quiero agarrar
            string nombreP = nombre.Substring(0, 4);

            Console.WriteLine("Su codigo es: " + pasT + nombreP);

            Console.ReadLine();

        }
    }
}
