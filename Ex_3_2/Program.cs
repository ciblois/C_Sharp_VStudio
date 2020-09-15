using System;

namespace Ex_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.2. Elaborar um programa que efetue a leitura sucessiva de valores numéricos e ver apresente no final 
            //o total do somatório, a média e o total de valores lidos. O programa deve fazer aquisição dos valores 
            //do teclado enquanto o utilizador introduzir valores positivos, ou seja, o programa deve parar quando
            //for fornecido um valor negativo.

            int i = 0, z = 0;
            int size = 0;
            int sum = 0;
            int mean = 0;
           
            while (i >= 0)
            {
                Console.WriteLine("Type one number. If you want to stop, type a negative number. ");
                z = Convert.ToInt16(Console.ReadLine());
                if (z >= 0)
                {
                    sum = sum + z;
                }
                else
                {
                    break;
                }
                
                size = i + 1;                
                i++;
            }

            mean = sum / size;

            Console.WriteLine("\n\n Quantidade de números inseridos: " + size);
            Console.WriteLine("\n\n Somatório: " + Convert.ToString(sum));
            Console.WriteLine("\n\n Média: " + Convert.ToString(mean));
        }
    }
}
