using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero1;
            int Numero2;
            int resultado;
            
            Console.WriteLine("1-Resta");
            Console.WriteLine("2-Suma");
            Console.WriteLine("3-Division");
            Console.WriteLine("3-Division");
            Console.WriteLine("4-Multiplicacion");
            int calc = Convert.ToInt32(Console.ReadLine());

            switch (calc)
            {
                case 1:
                    Console.WriteLine("Digite Primer Numero");
                    Numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite Segundo Numero");
                    Numero2 = Convert.ToInt32(Console.ReadLine());
                    resultado = Numero1 - Numero2;
                    Console.WriteLine("Resulta de la Resta es " + resultado);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Digite Primer Numero");
                    Numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite Segundo Numero");
                    Numero2 = Convert.ToInt32(Console.ReadLine());
                    resultado = Numero1 + Numero2;
                    Console.WriteLine("Resulta de la Suma es " + resultado);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Digite Primer Numero");
                    Numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite Segundo Numero");
                    Numero2 = Convert.ToInt32(Console.ReadLine());
                    resultado = Numero1 / Numero2;
                    Console.WriteLine("Resulta de la Division es " + resultado);
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("Digite Primer Numero");
                    Numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite Segundo Numero");
                    Numero2 = Convert.ToInt32(Console.ReadLine());
                    resultado = Numero1  * Numero2;
                    Console.WriteLine("Resulta de la Multipplicacion es " + resultado);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Selecciones la Opcion Correcta");
                    Console.WriteLine("1-Resta");
                    Console.WriteLine("2-Suma");
                    Console.WriteLine("3-Division");
                    Console.WriteLine("4-Multiplicacion");
                    break;
            }
        }
    }
}
