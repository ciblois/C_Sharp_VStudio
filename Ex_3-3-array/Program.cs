using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Ex_3_3_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elabore um programa, que efetue a leitura de valores positivos inteiros até que seja introduzido 
            //um valor negativo.No final, deve ser apresentado o maior e o menor valor.

            int size = 10;
            int[] num = new int[size]; //solução com array
            int i = 0, z = 0;
            int max = 0;
            int min = 0;

            while (i < size)
            {
                Console.WriteLine("Type one number. If you want to stop, type a negative number. ");
                num[i] = Convert.ToInt16(Console.ReadLine());
                if (num[i] < 0)
                {
                    num[i] = 0;
                    break;
                }
                i++;
            }

            while (z < size)
            {
                Console.Write(num[z] + ", ");
                z++;
            }

            max = num.Max();
            min = num.Min();
            
            Console.WriteLine("\n\n The max num is " + max + " and the min is " + min + ".");
        }
    }
}
