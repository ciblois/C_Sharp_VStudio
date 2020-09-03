using System;

namespace Ex_2_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Crie um programa que determine o maior de três valores introduzidos a partir do teclado.

            float var1, var2, var3;

            Console.WriteLine("Let's compare 3 numbers!");
            Console.WriteLine("Type the first number: ");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the second number: ");
            var2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the third number: ");
            var3 = Convert.ToInt32(Console.ReadLine());

            if (var1 > var2)
            {
                if (var1 > var3)
                {
                    Console.WriteLine("The largest number is " + var1);
                }
                else
                {
                    Console.WriteLine("The largest number is " + var3);
                }
            }
            if (var1 < var2)
            {
                if (var2 > var3)
                {
                    Console.WriteLine("The largest number is " + var2);
                }
                else
                {
                    Console.WriteLine("The largest number is " + var3);
                }
            }
        }
    }
}
