using System;

namespace Ex_2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //    Crie um programa que peça ao utilizador dois valores e este devolva, o maior deles.

            floar var1, var2;
            
            Console.WriteLine("Type one number: ");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the second number: ");
            var2 = Convert.ToInt32(Console.ReadLine()):

            if (var1 > var2)
            {
                Console.WriteLine(var1);
            }
            if (var1 < var2)
            {
                Console.WriteLine(var2);
            }
            else
            {
                Console.WriteLine("They are equal.");
            }
        }
    }
}
