using System;

namespace Tarea_2
{
    class Program
    {
        static void Main(string[] args)
        {   /*///////////PUNTO 1/////////////

            Console.WriteLine("\t\tTarea 2");
            Console.WriteLine("\nEjercicio 1");

            Console.WriteLine("\nIngrese un valor para que sea multiplo de 5: ");
            int numero= int .Parse(Console.ReadLine());

            if(numero%5==0)
            {
                Console.WriteLine("\nEl número es multiplo de 5");
            }

            else 
            {
                Console.WriteLine("\nEl número NO es multiplo de 5, pruebe otro");
            }

            Console.ReadLine();*/

            ////////PUNTO 2/////////////

            Console.WriteLine("\t\tTarea 2");
            Console.WriteLine("\nEjercicio 2");

            Console.WriteLine("\nIngrese las horas que trabaja el empleado en el mes: ");
            int horas = int.Parse(Console.ReadLine());
            float sueldo1=0, sueldo2=0;

            if (horas < 30)
            {
                sueldo1 = horas * 10;
                Console.WriteLine("\nEl sueldo mensual del empleado es de: " + sueldo1);

            }
            else if (horas >= 30)
            {

                sueldo2 = horas * 20;
                Console.WriteLine("\nEl sueldo mensual del empleado es de: " + sueldo2);

            }

            Console.ReadLine();
        }
    }
}



///////Punto 3/////////
/*
            Console.WriteLine("\t\tTarea 2");
            Console.WriteLine("\nEjercicio 3");

            Console.WriteLine("\nIngrese el primer número: ");
            decimal numero1= decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("\nIngrese el segundo número: ");
            decimal numero2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese un caracter: ");
            Console.WriteLine("\nLos caracteres ingresados pueden ser + - * /: ");
            string caracter = Console.ReadLine();

            decimal cuenta=0m;
          

            switch(caracter)
            {
                case "+": cuenta = numero1 + numero2;break;
                case "-": cuenta = numero1 - numero2;break;
                case "*": cuenta = numero1 * numero2;break;
                case "/": cuenta = numero1 / numero2;break;
                default: Console.WriteLine("\nIngresó un valor erroneo");break;
            }
            
            Console.WriteLine("\n**El resultado es: " + cuenta);

            Console.ReadLine();
        }
    }
}

    */
