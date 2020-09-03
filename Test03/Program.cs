using System;

namespace Test03
{
    class Program
    {
        static void Main(string[] args)
        {
            float var1, var2, soma, sub, mult, div;

            Console.WriteLine("Introduza o primeiro número: ");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza o segundo número: ");
            var2 = Convert.ToInt32(Console.ReadLine());

            soma = var1 + var2;
            sub = var1 - var2;
            mult = var1 * var2;
            div = var1 / var2;

            Console.WriteLine("As operações matemáticas possíveis são: ");
            Console.WriteLine("A soma é:" + soma);
            Console.WriteLine("A subtração é: " + sub);
            Console.WriteLine("A multiplicação é: " + mult);
            Console.WriteLine("A divisão é: " + div);
        }
    }
}
