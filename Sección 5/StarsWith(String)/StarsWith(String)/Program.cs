using System;

namespace StarsWith_String_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string aves = "Pollo";

            if (aves.StartsWith('P'))
            {
                Console.WriteLine("\nEmpieza con P");
            }

            else
            {
                Console.WriteLine("\nNO EMPIEZA CON P");
            }

            Console.ReadLine();
            */
            string[] nombres = { "Pepe", "Pedro", "Pablo" };
            int c = 0;
            foreach(string nom in nombres)
            {
                if (nom.StartsWith("P"))
                {
                    c++;
                }
            }
            Console.WriteLine("\nEmpiezan con P " + c + " nombres");
        }
    }
}