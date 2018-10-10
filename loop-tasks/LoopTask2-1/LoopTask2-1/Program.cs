using System;

namespace LoopTask2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kokonaisluvut 1-10 ja niiden neliöjuuret");
            Console.WriteLine("Luku\tNeliöjuuri");
            double square = 1;
            int i = 1;

            for (i = 1; i <= 10; i++)
            { 
                square = Math.Sqrt(i);
                square = Math.Round(square, 2);
                Console.WriteLine($"{i}\t{square}");
            }
        }
    }
}