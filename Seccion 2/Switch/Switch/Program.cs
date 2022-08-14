using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tSwitch");
            Console.WriteLine("\n Ingrese la nota del alumno: ");
            string nota = Console.ReadLine();
            
            switch(nota)
            {
                case "A": Console.WriteLine("El alumno está aprobado");break;
                case "B": Console.WriteLine("El alumno tiene que reforzar");break;
                case "C": Console.WriteLine("El alumno está desaprobado"); break;
                default:break;

                    Console.ReadLine();
            }
        }


        }
    }
