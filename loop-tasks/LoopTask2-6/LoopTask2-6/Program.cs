using System;

namespace LoopTask2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Tee ohjelma, joka simuloi nopanheittoa 1000 kertaa ja tulostaa " +
                "lisäksi kuutosen esiintymiskertojen lukumäärän.");

            int i = 1;
            int result = 1;
            int countOfSix = 0;
            Random rnd = new Random();

            do
            {
                result = rnd.Next(1, 7);
                if (result == 6)
                {
                    countOfSix++;
                }
                Console.WriteLine($"{i}. {result}");
                i++;
            } while (i <= 1000);
            Console.WriteLine($"Kuutonen arvottiin {countOfSix} kertaa.");
        }
    }
}