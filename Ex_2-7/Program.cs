using System;

namespace Ex_2_7
{
    class Program
    {
        static void Main(string[] args)
        {

            //Crie um programa que peça ao utilizador:
            //o O consumo médio de um automóvel por cada 100KM.
            //o O tamanho do depósito em litros;
            //o O preço do litro em euros;
            //o E os quilómetros a percorrer numa viagem.
            //Este por sua vez, deve calcular:
            //2.7.1.Qual o gasto em combustível(litros e dinheiro);
            //2.7.2.Quantas vezes deverá parar para abastecer;
            //2.7.3.Quantos quilómetros será possível percorrer com cada depósito.

            Console.WriteLine("Let's check you car!");

            float avg = 0.0f, tank = 0.0f, tank_price = 0.0f, liter_price = 0.0f, liter = 0.0f, money = 0.0f, dist = 0.0f;
          
            //Tem que usar vírgula. Se usar ponto não funciona.
            
            Console.WriteLine("Average car consumption per 100km: ");
            avg = float.Parse(Console.ReadLine());
            Console.WriteLine("Fuel tank size in liters: ");
            tank = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Liter price in euros: ");
            liter_price = Convert.ToSingle(Console.ReadLine());

            liter = avg * 100;
            money = liter * liter_price;
            tank_price = tank * liter_price;
            dist = tank/avg;

            Console.WriteLine("The car consuption " + liter + " liters per 100km and it cust " + money + " euros.");
            Console.WriteLine("The cust to full fill the tank is:  " + tank_price + " euros.");
            Console.WriteLine("The average distance with full tank is:  " + dist + " km.");
        }
    }
}
