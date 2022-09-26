using System;

namespace NuevoCSharp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int mul = 2;
            int mul2 = 5;
            int mul3 = 8;
            int resultado = Multiplicacion(mul, mul2, mul3);
            Console.WriteLine(resultado);
            Prueba();

            Console.WriteLine("HOla Mundo");


        }

        static int Multiplicacion(int m, int m2, int m3)
        
        {
            return m * m2 * m3;
        }

        static void Prueba()
        {
            Console.WriteLine("Probando Metedos");
            int algo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Probando Metedos 2");
            int algo2 = Convert.ToInt32(Console.ReadLine());

            int resul = algo + algo2;

            Console.WriteLine("resultado es {0}", resul);
            Console.ReadKey();
        }

    }
}
