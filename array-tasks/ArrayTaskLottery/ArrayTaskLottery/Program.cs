using System;

namespace ArrayTaskLottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo 7 eri lukua 1-40 ja tulostaa arvotut luvut pienimmästä suurimpaan.");

            int rng, extraNumber, doubleUp;
            string extraNo = "";
            string lottoResult = "Loton oikea rivi on: ";
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
            for (int i = 0; i < lottery.Length; i++)
            {
                extraNumber = rnd.Next(40);
                if (lottery[extraNumber] == 0)
                {
                    lottery[extraNumber] = 2;
                    break;
                }

            }
            for (int i = 0; i < lottery.Length; i++)
            {
                if (lottery[i] == 1)
                {
                    lottoResult += $"{i},";
                }

                else if (lottery[i] == 2)
                {
                    extraNo = $"Lisänumero on: {i}";
                }
            }

            lottoResult = lottoResult.Remove(lottoResult.Length - 1);
            Console.WriteLine(lottoResult);
            Console.WriteLine(extraNo);

            doubleUp = rnd.Next(40);
            Console.WriteLine($"Tuplausnumero: {doubleUp}");
        }
    }
}