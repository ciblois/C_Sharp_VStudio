using System;

namespace Ex_2_10
{
    class Program
    {
        static void Main(string[] args)
        {

            //Crie um programa que determine se um número é múltiplo de 5.

            float number;

            Console.WriteLine("Let's check if a number is a multiple of 5!");
            Console.WriteLine("Give me a number to check: ");

            number = Convert.ToInt32(Console.ReadLine());

            if (number %5 == 0)
            {
                Console.WriteLine("This number is a multiple of 5!");
            }
            else
            {
                Console.WriteLine("This number is not a multiple of 5.");
            }
        }
    }
}
