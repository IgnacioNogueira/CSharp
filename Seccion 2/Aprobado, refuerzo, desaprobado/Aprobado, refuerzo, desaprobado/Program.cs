using System;

namespace Aprobado__refuerzo__desaprobado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tCondición de alumnos");
            Console.WriteLine("\t\nCondición de notas \n.A=Aprobado \n.B=Necesita refuerzo \n.C=Desaprobado");

            Console.WriteLine("\nIngrese en en letras la nota del alumno: ");
            string valor = Console.ReadLine();

            if (valor.Equals("A") || valor.Equals("a"))
            {
                Console.WriteLine("El alumno está aprobado");

            }
            else if (valor.Equals("B") || valor.Equals("b"))
            {
                Console.WriteLine("El alumno necesita refuerzo");
            }

            else if (valor.Equals("C") || valor.Equals("c"))
            {
                Console.WriteLine("El alumno está desaprobado");
            }
                Console.ReadLine();
        }
    }
}
