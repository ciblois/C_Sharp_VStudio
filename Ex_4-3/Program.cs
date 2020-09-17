using System;
using System.Linq;

namespace Ex_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.3. Peça ao utilizador para introduzir 10 valores a partir do teclado, guarde-os num array.
            //4.3.1.Quantos números pares existem ?
            //4.3.2.Quantos números existem menores que a média?
            
            int size = 10;
            int[] num = new int[size]; //solução com array
            int i = 0, z = 0;
            int par = 0;
            double mean = 0;
            int count_mean = 0;
            
            while (i < size) //montar o array
            {
                Console.WriteLine("Type 10 numbers: ");
                num[i] = Convert.ToInt16(Console.ReadLine());                
                i++;
            }

            mean = num.Average();

            while (z < size)
            {                
                if (num[z] % 2 == 0)
                {
                    par = par + 1;
                }
                if (num[z] < mean)
                {
                    count_mean = count_mean + 1;
                }
                Console.Write(num[z] + "  ");
                z++;
            }

            Console.WriteLine("\n\n" + par + " numbers are even and " + count_mean + " are below the average.");
        }
    }
}
