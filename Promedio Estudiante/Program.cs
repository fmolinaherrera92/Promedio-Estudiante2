using System;

namespace Promedio_Estudiante
{
    class Program
    {
        static void Main(string[] args)
        {

            int nota1;
            int nota2;
            int nota3;
            int nota4;


            Console.WriteLine("Saber el Promedio");

            Console.WriteLine("Calificacion 1");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Calificacion 2");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Calificacion 3");
            nota3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Calificacion 4");
            nota4 = Convert.ToInt32(Console.ReadLine());

            int resultado = (nota1 + nota2 + nota3 + nota4) / 4;

            if (resultado <= 100 && resultado >= 90)
            {
                Console.WriteLine("Su Promedio es A");
            }
            else if (resultado <= 89 && resultado >= 80)
            {
                Console.WriteLine("Su Promedio es B");
            }
            else if (resultado <= 79 && resultado >= 70)
            {
                Console.WriteLine("Su Promedio es C");
            }
            else
            {
                Console.WriteLine("Repite Materia");
            }

        }
    }
}
