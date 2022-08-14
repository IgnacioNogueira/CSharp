using System;

namespace ToCharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Pepe";
            char[] array = nombre.ToCharArray(); //transforma los caracteres para poder contarlos
            int c = 0;

            foreach(char item in array)
            {
                if(item.Equals('e'))
                {
                    c++;
                }
            }
            Console.WriteLine("\nSe repite la letra e " + c + " veces");
            Console.ReadLine();
        }
    }
}
