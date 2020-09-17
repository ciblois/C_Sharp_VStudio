using System;

namespace Ex_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.5.Peça ao utilizador para introduzir 10 valores a partir do teclado, guarde - os num array. 
            //Crie um algoritmo para ordenar o array por ordem ascendente. Posteriormente implemente o algoritmo 
            //na linguagem C#.

            int size = 10;
            int[] num = new int[size]; // array
            int i = 0, z = 0;

            while (i < size)
            {
                Console.WriteLine("Type 10 numbers: ");
                num[i] = Convert.ToInt16(Console.ReadLine());
                i++;
            }
        }
    }
}
