using System;

namespace Ex_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.1. Imprima no ecrã os primeiros 7 números começando em 10.

            int size = 7;
            int i = 10; // inicializador

            while (i < 10 + size)
            {
                Console.WriteLine(i);
                i++;
            }

        }
    }
}
