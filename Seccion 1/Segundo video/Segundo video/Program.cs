using System;

namespace Segundo_video
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 50;
            int b = 40;
            double c = 20.5;
            int residuo = a % b; //residuo=%
            int suma = a + b;
            int resta = a - b;
            int multiplicacion = a * b;
            double division = (a*1.0) / b; /* Se hace *1.0 para que salga
                                            correcta la division, sino te sale 1, 
                                            siempre uno de ellos tiene que ser decimal*/

            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("La resta es: " + resta);
            Console.WriteLine("La multiplicacion es: " + multiplicacion);
            Console.WriteLine("La division es: " + division);
            Console.WriteLine("El residuo es: " +residuo);

            Console.ReadLine();
        }
    }
}
