using System;

namespace RecapTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kysyy käyttäjältä lukuja, kunnes hän syöttää luvun -1. Ohjelma tulostaa näytölle syötettyjen lukujen summan.");
            int sum = 0;

            while (true)
            {
                Console.Write("Syötä luku: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);

                if (isNumber && userInput != -1)
                {
                    sum += userInput;
                }
                else if (isNumber && userInput == -1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Syötteen pitää olla luku.");
                }
            }
            Console.WriteLine($"Lukujen summa on: {sum}");
        }
    }
}