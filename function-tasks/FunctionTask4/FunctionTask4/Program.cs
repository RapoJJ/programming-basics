using System;

namespace FunctionTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma pyytää käyttäjältä 10 positiivista kokonaislukua ja palauttaa niistä suurimman.");

            int bigNumber = 0;
            Console.WriteLine($"{BiggestNumber(ref bigNumber)} ja {bigNumber}");
        }
        static int BiggestNumber(ref int maxNumberSlot)
        {
            int maxNumber = 0;
            string numbers = "";

            Console.WriteLine("Syötä 10 positiivista lukua.");

            for (int i = 1; i <= 10;)
            {
                Console.Write($"{i}. ");
                bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);

                if (isNumber && userInput > 0)
                {
                    numbers += $"{userInput} ";
                    if (userInput > maxNumber)
                    {
                        maxNumber = userInput;
                        maxNumberSlot = i;
                    }
                    i++;
                }
                else
                {
                    Console.WriteLine("Ei sallittu syöte. Syötteen pitää olla positiivinen luku!");
                }
            }
            Console.WriteLine($"Syötit luvut: {numbers}");
            return maxNumber;
        }
    }
}
