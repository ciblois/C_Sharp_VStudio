using System;

namespace Ex_2_11
{
    class Program
    {
        static void Main(string[] args)
        {

        //Criar um programa que recebe um número do teclado e mostra se ele é divisível por 10, por 5, 
        //por 2 ou se não é divisível por nenhum destes.

        Console.WriteLine("Let's check if a number is divisible per 10, 5, 2 or none.");

        float number = 0.0f;

            Console.WriteLine("Type the numer here: ");
            number = Convert.ToSingle(Console.ReadLine());

            if (number % 2 == 0 & number % 5 == 0)
            {
                Console.WriteLine("This number is divisible per 10.");
            }
            if (number % 5 == 0)
            {
                Console.WriteLine("This number is divisible per 5.");
            }
            if (number % 2 == 0)
            {
                Console.WriteLine("This number is divisible per 2.");
            }
            else
            {
                Console.WriteLine("This number is NOT divisible per 10, 5, 2.");
            }
        }
    }
}
