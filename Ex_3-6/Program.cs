using System;

namespace Ex_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.6. Introduzir números sucessivamente até ser introduzido um número negativo. Mostrar ao utilizar
            //o número de números pares introduzidos.

            int i = 0, z = 0, par = 0;

            while (i >= 0)
            {
                Console.WriteLine("Type one number. If you want to stop, type a negative number. ");
                z = Convert.ToInt16(Console.ReadLine());
                if (z >= 0)
                {
                    //j = Convert.ToString(z); //teste para imprimir a lista digitada

                    if (z %2 == 0)
                    {
                        par = par + 1;
                    }
                }
                else
                {
                    break;
                }
                i++;
            }

            Console.WriteLine("\n\n Qauntidade de números pares: " + Convert.ToString(par));
        }
    }
}
