using System;

namespace FunctionTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma pyytää käyttäjältä 10 positiivista kokonaislukua ja palauttaa niistä suurimman.");

            int number = 0;
            Console.WriteLine($"Syöttämistäsi luvuista suurin oli {BiggestNumber(ref number)} ja se oli {number}. luku.");
        }
        static int BiggestNumber(ref int maxNumberSlot)
        {
            int bigNumber = 0;
            string numbersInputted = "";

            Console.WriteLine("Syötä 10 positiivista lukua.");

            for (int i = 1; i <= 10;)
            {
                Console.Write($"{i}. ");
                bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);

                if (isNumber && userInput > 0)
                {
                    numbersInputted += $"{userInput} ";
                    if (userInput > bigNumber)
                    {
                        bigNumber = userInput;
                        maxNumberSlot = i;
                    }
                    i++;
                }
                else
                {
                    Console.WriteLine("Ei sallittu syöte. Syötteen pitää olla positiivinen luku!");
                }
            }
            Console.WriteLine($"Syötit luvut: {numbersInputted}");
            return bigNumber;
        }
    }
}