using System;
using System.Data;

namespace Ex_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0, menor21 = 0, maior50 = 0;

            while (idade != -99)
            {
                Console.WriteLine("Introduza a sua idade ou digite -99 para encerrar o programa: ");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade < 21 && idade > 0)
                {
                    menor21++;
                }

                if (idade > 50 && idade > 0)
                {
                    maior50++;
                }
            }

            Console.WriteLine("\n\n Idadaes introduzidas menor que 21: " + menor21);
            Console.WriteLine("\n Idadaes introduzidas maior que 50: " + maior50);
        }
    }
}
