using System;

namespace ToUpper_ToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            string utiles = "Me fui de Paseo";

            Console.WriteLine(utiles.ToUpper());

            Console.WriteLine(utiles.ToLower());

            string nombre1 = "Pablo";
            // PABLO
            string nombre2 = "pablo";
            //PABLO
            if (nombre1.ToLower().Equals(nombre2.ToLower()))
            {
                Console.WriteLine("Son igualitos");
            }
            else
            {
                Console.WriteLine("Son diferentes");
            }


            Console.ReadLine();
        }
    }
}
