using System;

namespace Ex_2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Crie um programa que determine se a idade introduzida do teclado é de uma pessoa
            //de maioridade ou de menoridade.
            
            int age;

            Console.WriteLine("Type your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are of legal age.");
            }
            else
            {
                Console.WriteLine("You are underage.");
            }
        }
    }
}
