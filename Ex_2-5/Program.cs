using System;

namespace Ex_2_5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Crie um programa que peça dois valores ao utilizador. Seguidamente este deverá pedir a 
            //operação a realizar: 1) Soma, 2) Subtração; 3) Multiplicação; 4) Divisão.

            float num1, num2, soma, subs, mult, div;
            string operation;

            Console.WriteLine("Type the first number: ");
            num1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Type the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the operation you would like to do.");
            Console.WriteLine("Choose s for sum, su for substraction, m for multiplication or d for division: ");
            operation = Console.ReadLine();

            soma = num1 + num2;
            subs = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;

            if (operation == "s" | operation == "su" | operation == "m" | operation == "d")
            {
                if (operation == "s")
                {
                    Console.WriteLine("The sum is " + soma);
                }
                if (operation == "su")
                {
                    Console.WriteLine("The substraction is " + subs);
                }
                if (operation == "m")
                {
                    Console.WriteLine("The multiplication is " + mult);
                }
                if (operation == "d")
                {
                    Console.WriteLine("The division is " + div);
                }
            }
            else
            {
                Console.WriteLine("You type something wrong. Please try again.");
            }
        }
    }
}
