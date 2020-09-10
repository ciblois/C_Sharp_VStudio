using System;
using System.Linq;

namespace Ex_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.2. Crie um array com quatro posições para guardar números.
            int size = 4;
            double[] salary = new double[size];

            double sal_value = 0;
            double sum = 0;
            double min = 0;
            double max = 0;
            double mean = 0;

            int i = 0;
            int j = i + 1;

            while (i < size)
            {
                //4.2.1.Peça ao utilizador para introduzir o salário de 4 funcionários da empresa
                //a partir do teclado, guarde-os num array com o tipo de dados indicado para o efeito e 
                //realize as seguintes operações sobre o array construído:
                Console.WriteLine("Enter an employee's salary amount: ");
                sal_value = Convert.ToDouble(Console.ReadLine());
                salary[i] = sal_value;
                sum = sum + sal_value;
                i++;
            }

            //4.2.2.Soma de todos os valores do array;
            Console.WriteLine("The sum of the salaries is: " + sum);

            //4.2.3.Qual é o salário máximo;
            max = salary.Max();
            Console.WriteLine("Max: " + max);

            //4.2.4.Qual é o número mínimo?
            min = salary.Min();
            Console.WriteLine("Min: " + min);

            //4.2.5.Qual a media dos salários?
            mean = sum / Convert.ToDouble(size);
            Console.WriteLine("The mean is: " + mean);
        }
    }
}
