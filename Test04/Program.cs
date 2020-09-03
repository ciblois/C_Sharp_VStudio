using System;

namespace Test04
{
    class Program
    {
        static void Main(string[] args)
        {
            float var1, var2;
            
            var1 = 0;
            var2 = 0;

        //WriteLine escreve string e muda de linha
        //Write escreve a string apenas

            Console.WriteLine("Type the first number: ");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the second number: ");
            var2 = Convert.ToInt32(Console.ReadLine());

            if (var1 > var2)
            {
                Console.WriteLine("The fisrt one is bigger.");
            }
            if (var1 == var2)
            {
                Console.WriteLine("They are equal.");
            }
            else
            {
                Console.WriteLine("The second one is bigger.");
            }

        }
    }
}
