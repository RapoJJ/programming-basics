using System;

namespace ArrayTaskLottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo 7 eri lukua 1-40 ja tulostaa arvotut luvut pienimmästä suurimpaan.");

            int rng, extraNumber, doubleUp;
            Random rnd = new Random();
            int[] lottery = new int[40];

            for (int i = 0; i < 7; i++)
            {
                rng = rnd.Next(40);

                if (lottery[rng] == 0)
                {
                    lottery[rng] = 1;
                }
                else
                    i--;
            }
            Console.Write("Loton oikearivi on:");
            for (int i = 0; i < lottery.Length; i++)
            {
                if (lottery[i] == 1)
                {
                    Console.Write($"{i},");
                }

            }
            extraNumber = rnd.Next(40);
            lottery[extraNumber] = 2;

            doubleUp = rnd.Next(40);
            lottery[doubleUp] = 3;

            for (int i = 0; i < lottery.Length; i++)
            {
                if (lottery[i] == 2)
                {
                    Console.WriteLine($"\nLisänumero: {i}");
                }

            }
            for (int i = 0; i < lottery.Length; i++)
            {
                if (lottery[i] == 3)
                {
                    Console.WriteLine($"Tuplausnumero: {i}");
                }
            }
        }
    }
}