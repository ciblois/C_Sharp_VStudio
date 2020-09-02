using System;

namespace Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1, var2, soma;

            Console.WriteLine("Type the first number you want to sum");
            var1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type the second number you want to sum");
            var2 = Convert.ToInt32(Console.ReadLine());

            soma = var1 + var2;

            Console.WriteLine("The sum is " + soma);
        }
    }
}
