using System;

namespace LoopTask2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa vakioveikkauksen rivin " +
                "(13 kohdetta, 1 = kotivoitto, X = tasapeli ja 2 = vierasvoitto)");

            int i = 1;
            double outcome = 1;
            Random rnd = new Random();

            do
            {
                outcome = rnd.NextDouble();

                if (outcome <= 0.4)
                    Console.WriteLine($"{i}. 1");
                else if (outcome <= 0.6)
                    Console.WriteLine($"{i}. X");
                else
                    Console.WriteLine($"{i}. 2");
                i++;
            }while (i <= 13);
        }
    }
}
