using System;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;

namespace Ex_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elabore um programa, que efetue a leitura de valores positivos inteiros até que seja introduzido 
            //um valor negativo.No final, deve ser apresentado o maior e o menor valor.
            
            //int size = 7;
            int i = 0, z = 0;
            int size = 0;
            //string j = ""; //teste para imprimir a lista digitada
            //string list = ""; //teste para imprimir a lista digitada

            //int[] num = new int[size]; //solução com array

            float max = 0, min = 100000;

            while (i >= 0)
            {
                Console.WriteLine("Type one number. If you want to stop, type a negative number. ");
                z = Convert.ToInt16(Console.ReadLine());
                if (z >= 0)
                {
                    //j = Convert.ToString(z); //teste para imprimir a lista digitada
                 
                    if (max < z)
                    {
                        max = z;
                    }
                    if (min > z)
                    {
                        min = z;
                    }
                }
                else
                {
                    break;
                }
                //list = list + ", " + j; //teste para imprimir a lista digitada

                size = i + 1;
                
                //num[i] = Convert.ToInt16(Console.ReadLine()); //solução com array
                
                i++;
            }

            Console.WriteLine("size: " + size);

            //max = int[].Max();
            //min = int[].Min();

            Console.WriteLine("\n\n Max: " + Convert.ToString(max));
            Console.WriteLine("\n\n Min: " + Convert.ToString(min));

            //Console.WriteLine("List: " + list);
        }
    }
}
