using System;

namespace Ejercicio_descuento_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tEjercicio descuento con Switch");
            Console.WriteLine("\nIngrese el sueldo del empleado: ");
            float sueldo= float .Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese la categoria del empleado: ");
            Console.WriteLine("\nLas categorias son A, B Y C");
            string categoria = Console.ReadLine();
            float aumento, total;
            
            switch (categoria)
            {
                case "A": aumento = 500;break;
                case "B": aumento = 300; break;
                case "C": aumento = 100; break;
                default: aumento = 10;break;
            }
            
            total = sueldo + aumento;
            Console.WriteLine("\n**El aumento es de: " + aumento);
            Console.WriteLine("\n**Ahora el sueldo es de: " + total);


            Console.ReadLine();


        }
    }
}
