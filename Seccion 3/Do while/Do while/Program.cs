using System;

namespace Do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tDo While");
            int numero, c = 0, i = 1; //el i=1 es para que sea vea visualmente en el ingreso numero (*)

            do
            {
                Console.WriteLine("\nIngrese el numero " + i); /*-Acá es como en el printf("...%i",nro);
                                                                                      -Arranca en el 1 por lo declarado arriba*/
                numero = int.Parse(Console.ReadLine());
                i++;
                c++; //para que me cuente cuántas veces está haciendo esta operación

            } while (numero >= 0);
            Console.WriteLine("\nTotal de ingresos de números positivos: " + (c - 1)); /*esto porque el do while cuenta igual (no piensa,actua)
                                                                                        si no hubiese puesto el -1, me contaba hasta el negativo*/

            Console.WriteLine("\nIngreso un numero negativo, error");                   


            Console.ReadLine();






        }
    }
}
