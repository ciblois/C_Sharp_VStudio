using System;

namespace Ex_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.4. Peça ao utilizador para introduzir 10 valores a partir do teclado, guarde-os num array. 
            //Inverta a ordem do array.
            //Ex.:  array introduzido { 5,2,7,4,9}
            //      array resultado { 9, 4, 7, 2, 5}

            int size = 10;
            int[] num = new int[size]; //array introduzido
            int[] num_inv = new int[size]; //array invertido
            int i = 0;
            int y = 0;
            int z = 0;

            while (i < size)
            {
                Console.WriteLine("Type one number. If you want to stop, type a negative number. ");
                num[i] = Convert.ToInt16(Console.ReadLine());
                num_inv[size - 1 - i] = num[i];
                i++;
            }

            Console.WriteLine("\n Original Array: ");

            while (y < size)
            {
                Console.Write(num[y] + "  ");
                y++;
            }

            Console.WriteLine("\n\n Inverted Array: ");

            while (z < size)
            {
                Console.Write(num_inv[z] + "  ");
                z++;
            }
        }
    }
}
