using System;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace Ex_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.5. Crie um programa que peça a introdução por parte do utilizador, de um número entre 1 e 4. 
            //Se o valor estiver fora da gama pedida, então mostrar a mensagem "entrada inválida" e solicitar 
            //o número novamente.Se escrever um valor correto, então mostrar o número introduzido.

            int num = 0;

           
           Console.WriteLine("Choose a number between 1 and 4: ");
           num = Convert.ToInt16(Console.ReadLine());
           if (num >= 0 & num <= 4)
           {
                Console.WriteLine("Ok");
           }
            else
            {
                while (num < 0 | num > 4)
                {
                    Console.WriteLine("It's out of the range. Type again.");
                    num = Convert.ToInt16(Console.ReadLine());
                }
            }
        }
    }
}
