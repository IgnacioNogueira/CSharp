using System;

namespace Triple_de_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tTriple de un numero");
            
            Console.WriteLine("\n***Ingrese un numero para calcular su resultado x3: ***");
            int numero = int.Parse(Console.ReadLine());
            int numeroTriple = 0;
            numeroTriple = numero * 3;
            Console.WriteLine("\nEl triple es= " + numeroTriple); /*Acá se mete y se hace una cuenta
                                                                    A partir de que se mete en el ciclo while
                                                                    empieza a hacer el bucle, por lo tanto son dos secciones distintas*/

            while (numero !=0)
            {
                Console.WriteLine("\n---Ingrese un numero para calcular su resultado x3: ---");
                numero = int.Parse(Console.ReadLine()); //no poner int ya que se declaró arriba
                numeroTriple = numero * 3;
                Console.WriteLine("\nEl triple es= " + numeroTriple);

            }
            Console.WriteLine("\nIngreso un valor al que no se puede multiplicar");
        }
    }
}
