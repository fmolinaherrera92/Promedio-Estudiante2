using System;
using System.Collections.Generic;

namespace Consol_Posi_Negat_Neut
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Digite el dia de la semana(SwitchCase)
            /**
            Console.WriteLine("Digite el dia de la semana");
            string Semana = Console.ReadLine();

            switch (Semana)
            {
                case "lunes":
                    Console.WriteLine("Dia de la semana");
                    break;
                case "martes":
                    Console.WriteLine("Dia de la semana");
                    break;
                case "miercoles":
                    Console.WriteLine("Dia de la semana");
                    break;
                case "jueves":
                    Console.WriteLine("Dia de la semana");
                    break;
                case "viernes":
                    Console.WriteLine("Dia de la semana");
                    break;
                case "sabado":
                    Console.WriteLine("Fin de Semana");
                    break;
                case "domingo":
                    Console.WriteLine("Fin de Semana");
                    break;
                default:
                    Console.WriteLine("No es ningun dia de la semana");
                    break;
            }**/
            #endregion

            #region Determinar cantidad de numero positivos, negativos y neutros
            /**
           //Determinar cantidad de numero positivos, negativos y neutros
           Console.WriteLine("Digite la Cantidad de numero");
           int cantidad = Convert.ToInt32(Console.ReadLine());
           int Limite = 1;
           int negativo = 0;
           int positivo = 0;
           int neutro = 0;

           while (Limite <= cantidad)
           {
               Console.WriteLine($"Digite un Numero {Limite}");
               int numero = Convert.ToInt32(Console.ReadLine());

               if (numero < 0)
               {
                   negativo++;
               }
               else if (numero > 0)
               {
                   positivo++;
               }
               else if (numero == 0)
               {
                   neutro++;
               }

               Limite++;
           }

           Console.WriteLine($"Negativo{negativo}" );
           Console.WriteLine($"Positivo {positivo}");
           Console.WriteLine($"Neutro {neutro}" );

           int aunmentar = 0;
           int contadorAnterior = 0;
           string aumentarStr = "";

           for (int lim = 0; lim <= 100; ++lim)
           {
               aunmentar = +lim;
               aumentarStr += $"{contadorAnterior}+{lim}={(contadorAnterior + lim)},";
               contadorAnterior = lim;
           }
           Console.WriteLine(aumentarStr);
           Console.WriteLine($"Total es: {aunmentar}");
            #endregion

            #region NumeroMayorMenor
            /**
           Console.WriteLine("digite primer numero");
           int numero = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("digite segun numero");
           int numero2 = Convert.ToInt32(Console.ReadLine());

           if (numero < numero2)
           {
               Console.WriteLine("el Numero " + numero2 + " al " + "Mayor a " + numero);
           }
           else if (numero > numero2)
           {
               Console.WriteLine("el Numero " + numero + " " + "Mayor a " + numero2);
           }
           else if (numero == numero2)
           {
               Console.WriteLine("Ambos Numeros son igual");
           }**/
            #endregion

            #region Digite el dia de la semana
            /**
            Console.WriteLine("Digite el dia de la semana");
            string Semana = (Console.ReadLine());

            if (Semana == "lunes" || Semana == "martes" || Semana == "miercoles" || Semana == "jueves" || Semana == "viernes")
            {
                Console.WriteLine("Dia de Semana");

            }
            else if (Semana == "sabado" || Semana == "domingo")
            {
                Console.WriteLine("Fin de Semana");
            }
            else
            {
                Console.WriteLine("No es ningun dia de la semana");
            }**/
            #endregion

            #region  precio de un producto
            
            float efectivo = 0;
            float Sobra = 0;
            string tarjeta = "12345";
            Console.WriteLine("Cual es el precio del Producto");
            float prod = float.Parse(Console.ReadLine());

            Console.WriteLine("Metodo de pago 1 - Efectifo o 2- Tarjeta");
            string tipoPago = Console.ReadLine();

            switch (tipoPago)
            {
                case "1":


                    Console.WriteLine("Monto a pagar es:" + " " + prod);
                    efectivo = float.Parse(Console.ReadLine());
                    Sobra = efectivo - prod;

                    if (prod == efectivo)
                    {
                        Console.WriteLine("Muchas Gracias por su Compra");
                        Console.ReadKey();
                    }
                    else if (efectivo > prod)
                    {
                        Console.WriteLine($"DE volver:{Sobra}"   );
                        Console.ReadKey();
                    }
                    break;

                case "2":

                    Console.WriteLine("Digita numero de cuenta");
                    string validar = Console.ReadLine();

                    if (validar == tarjeta)
                    {
                        Console.WriteLine("Muchas Gracias por su Compra");
                        Console.ReadKey();
                    }
                    else if (validar != tarjeta)
                    {
                        Console.WriteLine("Numero de Cuenta incorrecto");
                        Console.ReadKey();
                    }
                    break;

                default:
                    break;
            }
            #endregion

            #region Recorre los números del 1 al 100. Usa un bucle for.
            /**
            int cien = 100;
            int contador = 0;
            Console.WriteLine("Ciclo For");
            for (int lim = 1; lim <= cien; lim++)
            {
                Console.WriteLine(lim);

            }**/
            #endregion

            #region Recorre los números del 1 al 100. Usa un bucle while.
            /**
            Console.WriteLine("Ciclo While");
            while (contador < 100)
            {
                contador++;
                Console.WriteLine(contador);
            }**/
            #endregion

            #region  Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.
            /**
            Console.WriteLine("Numeros Pares del 1 al 100");
            for (int lim = 0; lim <= cien; lim++)
            {
                Console.WriteLine(lim++);

            }**/
            #endregion

            #region Recorre los números del 1 al 100. Muestra los números pares o divisibles entre 3.

            //Console.WriteLine("Numeros Pares del 1 al 100");
            //for (int lim = 0; lim <=100; lim++)
            //{
            //    Console.WriteLine(lim + 2);

            //}
            #endregion

            #region ejercicios 5 al 9


            //Console.WriteLine("Mostrar los nùmeros impares entre el 0 y el 100");
            //for (int lim = 0; lim <= 100; ++lim)
            //{
            //    if (lim % 2 != 0)
            //    {
            //        Console.WriteLine(lim);
            //    }

            //}

            //Console.WriteLine("Mostrar los nùmeros pares entre el 0 y el 100");
            //for (int lim = 1; lim <= 100; ++lim)
            //{
            //    if (lim % 2 == 0)
            //    {
            //        Console.WriteLine(lim);
            //    }

            //}

            //Console.WriteLine("Mostrar los multiplos de 3 del 0 al 100");
            //for (int lim = 0; lim <= 100; ++lim)
            //{
            //    if (lim % 3 == 0)
            //    {
            //        Console.WriteLine(lim);
            //    }

            //}
            #endregion

            #region Mostrar los números del 1 hasta el número ingresado.
            //Console.WriteLine("digite numero");
            //int hola = Convert.ToInt32(Console.ReadLine());
            //for (int lim = 1; lim <= hola; lim++)
            //{
            //    Console.WriteLine(lim);

            //}
            #endregion

            #region multiplos de 3 desde la unidad hasta un num que ingresamos
            /**
            Console.WriteLine(" multiplos de 3 desde la unidad hasta un num que ingresamos");
            Console.WriteLine("digite numero");
            int hola = Convert.ToInt32(Console.ReadLine());
            for (int lim = 0; lim <= hola; ++lim)
            {
                if (lim % 3 == 0)
                {
                    Console.WriteLine(lim);
                }

            }
            **/
            #endregion

            #region Mostrar los números primos entre el 0 y 100.

            /**
            for (int lim = 0; lim <= 100; ++lim)
            {
                if (lim % 2 == 0 || lim % 3 == 0 || lim % 5 ==0 || lim % 7 == 0 || lim % 11  == 0 || lim % 13 == 0 )
                {
                    Console.WriteLine(lim);
                }

            }
            **/
            #endregion


            //algo();
        }
        /**
        static void algo() 
        {
            float num, mayor = 0, menor = 1, x = 0;
            int contador = 0;
            float num1, num2, auxi;

            while (contador < 10)
            {
                do
                {
                    Console.Write("Número:");
                    num = float.Parse(Console.ReadLine());

                } while (num == 0);

                if (num > 0)
                    mayor = mayor + num;
                if (num < 0)
                    menor = menor * num;

                contador++;
            }
            if (menor == 1)// En caso de que se ingrese todos +
                menor = 0;
            Console.Write($"La suma de los números Positivos es {mayor} y el producto de los Negativos es: {menor}");
            Console.ReadKey();


        }**/
    }

}
