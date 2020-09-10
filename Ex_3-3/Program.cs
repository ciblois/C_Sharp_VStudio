using System;
using System.ComponentModel;

namespace Ex_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float num = 0;
            //int i = 0;
            Array list[];

            while (num >= 0)
            {
                Console.WriteLine("Type one number. If you want to stop, type a negative number. ");
                //num = Convert.ToInt16(Console.ReadLine());
                num = Convert.ToInt16(Console.ReadLine());

                list = list + ", " + Convert.ToString(num);
            }

            Console.WriteLine("Numbers: " + list);

        }
    }
}
