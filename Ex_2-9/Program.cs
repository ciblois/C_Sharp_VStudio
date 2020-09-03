using System;

namespace Ex_2_9
{
    class Program
    {
        static void Main(string[] args)
        {

            //Crie um programa que verifique se um número é par.

            Console.WriteLine("Give me a number and I tell you if it's even.");
            Console.WriteLine("Type the number if I'll check: ");

            int number;

            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("This number is even!");
            }
            else
            {
                Console.WriteLine("This number is odd.");
            }
        }
    }
}
