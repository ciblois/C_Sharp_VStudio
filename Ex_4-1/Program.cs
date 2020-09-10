using System;

namespace Ex_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.1. Crie um programa que crie um array com 8 posições para guardar a idade de pessoas.
  
            int size = 8; //definir o tamanho do array
            int[] age = new int[size];

            int i = 0; //contador pro while
            int j = i + 1;

            int sum = 0;
            double mean = 0;

            while (i < size)
            {
                // 4.1.1.Inicialize o array com um valor inválido como idade “-1”.
                age[0] = -1;

                // 4.1.2.Mostre que o array ficou corretamente inicializado.
                //Console.WriteLine("The first element is: " + age[0]);

                while (j < size)
                {
                    // 4.1.3.Preencha o array com 8 idades;
                    int age_cons = 0;
                    Console.WriteLine("Type one age: ");
                    age_cons = Convert.ToInt16(Console.ReadLine());
                    age[j] = age_cons;
                    // 4.1.5.Calcule a média das idades do array;
                    //mean = sum/length
                    sum = sum + age[j];
                    j++;
                }

                // 4.1.4.Mostre que o array ficou preenchido com as 8 idades introduzidas;
                Console.WriteLine("Position: " + i + " Value: " + age[i]);            
                i++;
            }

            mean = Convert.ToDouble(sum / size);
            Console.WriteLine("\n\n The mean of ages is: " + mean);

            

            

        }
    }
}
