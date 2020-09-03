using System;

namespace Ex_2_8
{
    class Program
    {
        static void Main(string[] args)
        {

        //Crie um programa, que dado o número de quilómetros percorridos por um veículo e a duração da viagem 
        //(em minutos), este mostre a velocidade média da viagem.

         Console.WriteLine("Let's calculate the average speed of your trip.");

            float dist = 0.0f, vel = 0.0f;
            double time, time_h;

            Console.WriteLine("Let me know the distance of the trip in km.");
            dist = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Let me know how long it take in minutes.");
            time = Convert.ToDouble(Console.ReadLine());

            time_h = 0.0166666667 * time;
            vel = dist / Convert.ToSingle(time_h);

            Console.WriteLine("The average speed was " + vel + "km/h.");

        }
    }
}
