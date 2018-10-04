using System;

namespace LoopTask2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kokonaisluvut 1-10 ja niiden neliöjuuret");
            Console.WriteLine("Luku   Neliöjuuri");
            double square = 1;
            double i = 1;

            for (i = 1; i <= 10; i++)
            { 
                square = Math.Sqrt(i);
                Console.WriteLine($"{i}  {square}");
            }
        }
    }
}
