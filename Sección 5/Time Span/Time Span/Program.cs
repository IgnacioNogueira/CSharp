using System;

namespace Time_Span
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tTimeSpan");//es para definir la hora como un reloj

            //(DÍAS,HORAS,MINUTOS,SEGUNDOS,MILISEGUNDOS);
            TimeSpan objeto1 = new TimeSpan(12, 10, 5, 12, 8);
            TimeSpan objeto2 = new TimeSpan(5, 10, 8, 4, 12);

            Console.WriteLine(objeto2.CompareTo(objeto1));

           /* TimeSpan fechaTotal = objeto1 + objeto2;

            Console.WriteLine("\nEl total de días es: " + fechaTotal.TotalDays);
            
             */
           /* Console.WriteLine("\nHora: " + objeto1.Hours);
            Console.WriteLine("\nMinutos: " + objeto1.Minutes);

            TimeSpan objeto1 = new TimeSpan(4, 10, 29); 
            TimeSpan objeto2 = new TimeSpan(5, 15, 10); //hora, minutos, segundo y milisegundos

            TimeSpan objeto3= objeto1 + objeto2; //se suman dos horas
            
            Console.WriteLine(objeto3);
            */

            Console.ReadLine();
        }

    }
}
