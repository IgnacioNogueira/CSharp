using System;

namespace Remove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tRemove");

            string codigo = "120sasdaw5153";



            Console.WriteLine("\nAhora la cadena es :"+codigo.Remove(0, 2)); //Desde la posición 0 y quiero eliminar 2 caracteres

            Console.ReadLine();

        }
    }
}
