using System;

namespace Ex_2_6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Crie um programa que peça o preço com IVA incluído de um produto, a taxa de IVA e calcule o valor
            //do produto sem o IVA(FÓRMULA: preço_sem_iva = preço / (1 + taxa_iva_em_percentagem).

            float total_price, price, tax;

            Console.WriteLine("Give me the price you paid and the tax then I give to you the price without tax.");
            Console.WriteLine("Price: ");
            total_price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tax (without %): ");
            tax = Convert.ToInt32(Console.ReadLine());
            tax = tax / 100;

            price = total_price / (1 + tax);

            Console.WriteLine("The price without tax is " + price);

        }
    }
}
