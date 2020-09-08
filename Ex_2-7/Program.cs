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

            double avg = 0, tank = 0, tank_price = 0, liter_price = 0, liter = 0, money = 0, dist = 0, avg_dist = 0, stops = 0, money_tot = 0 ;
          
            //Tem que usar vírgula. Se usar ponto não funciona.
            
            Console.WriteLine("Average car consumption per 100km: ");
            avg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Fuel tank size in liters: ");
            tank = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Liter price in euros: ");
            liter_price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The distance to go: ");
            dist = Convert.ToDouble(Console.ReadLine());

            liter = avg * 100; // quantos litros por 1km
            money = liter * liter_price; // valor do gasto para 1km
            tank_price = tank * liter_price;
            avg_dist = tank*100/liter;
            stops = Math.Ceiling(dist/ avg_dist);
            money_tot = stops*tank_price;

            Console.WriteLine("\n\n The car consuption " + liter + " liters per 100km and it cust " + money + " euros.");
            Console.WriteLine("\n\n The cust to full fill the tank is:  " + tank_price + " euros.");
            Console.WriteLine("\n\n The average distance with full tank is:  " + avg_dist + " km.");
            Console.WriteLine("\n\n So you have to stop to " + stops + " times to refuel.");
            Console.WriteLine("And spend " + money_tot + "euros.");
        }
    }
}
