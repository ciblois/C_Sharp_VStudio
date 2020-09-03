using System;

namespace Ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Crie um programa que peça dois valores do teclado e caso a sua soma dê negativa, 
            //multiplique-a por (-1), mostrando no ecrã o resultado final.

            float var1, var2, resultado;

            Console.WriteLine("Type the first numer: ");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the second numer: ");
            var2 = Convert.ToInt32(Console.ReadLine());

            resultado = var1 + var2;

            if (resultado < 0)
            {
                resultado = resultado * (-1);
            }

            Console.WriteLine("The result is " + resultado);
        }
    }
}
