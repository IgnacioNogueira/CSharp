using System;

namespace Formas_de_definir_un_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tDefiniciones de los arrays (array de array)");

            /* int[] notas = new int[5]; //ahí le estoy diciendo que tiene que tener una longitud de 5
             notas[0] = 10;
             notas[1] = 20;
             notas[2] = 15;
             notas[3] = 12;
             notas[4] = 18;

             foreach(int numero in notas)
             {
                 Console.WriteLine(numero);
             }
             */
            string[,] nombresCompleto =  //[,] ---> array de array
            {
              {"Julio","Nieves","Sandoval" },  //indice 0
              {"Ricado","De la Cruz","Murayari"}, //apellido paterno - Indice 1
              {"Rolando","Garcia","Nogueira" }, //apellido materno - Indice 2
                                       
                                        /*-cada elemento un array ----> {},
                                          -tienen que tener todos la misma
                                          cant de elementos*/ 
            }; // no olvidarse el ;

            Console.WriteLine(nombresCompleto[0,0]); //fila x columna del (0,0)
            Console.WriteLine(nombresCompleto[0, 2]);

            Console.ReadLine();
        }
    }
}
