using System;

namespace La_clase_Math_para_los_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 2,c=9, d=-22;
            double precio = 20.5;

            //Math.Floor(precio); //elimina la parte decimal
            //Math.ceiling(precio) //borra lo decimal y suma uno
            //Math.round(precio) //redondea para arriba o abajo de cuál está más cerca
            //Math.Pow(a, b) //Eleva a la potencia
            //Math.sqrt(c) //Saca la raiz del numero
            //Math.Max(a, b) //Cúal es el mayor de dos numeros
            // Math.Min(a, b) //Cuál es el menor de dos numeros
            //Math.Abs(d)  //Saca el valor absoluto

            Console.WriteLine("\nMath.Floor(20.5): " + Math.Floor(precio));
            Console.WriteLine("\nMath.ceiling(20.5): "+Math.Ceiling(precio));
            Console.WriteLine("\nMath.round(20.5): " + Math.Round(precio));
            Console.WriteLine("\nMath.pow(a,b): " + Math.Pow(a, b));
            Console.WriteLine("\nMath.sqrt(c), la raiz es: " + Math.Sqrt(c));
            Console.WriteLine("\nMath.Max(a,b), el mayor es: " + Math.Max(a, b));
            Console.WriteLine("\nMath.Min(a,b) , el menor es: " + Math.Min(a, b));
            Console.WriteLine("\nMath.Abs(d), el valor absoluto es: " + Math.Abs(d));
                


            Console.ReadLine();
        }
    }
}
