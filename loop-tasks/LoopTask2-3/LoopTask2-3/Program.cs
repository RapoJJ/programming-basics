using System;

namespace LoopTask2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua väliltä [0-50].\n");
            Console.WriteLine("Vastaus:");
            Random rnd = new Random();
            int number = 1;

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Rivi {i} ");
                for (int j = 1; j <= 5; j++)
                {
                    number = rnd.Next(51); //New random number [0-50]
                    if (j == 5)         //If printing the last number of the row (Each row has 5 numbers)
                        Console.WriteLine($"{number}");
                    else
                        Console.Write($"{number}, ");
                }
            }
        }
    }
}
