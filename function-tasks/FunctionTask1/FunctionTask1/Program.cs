using System;

namespace FunctionTask1
{
    class Program
    {
        static void Main(string[] args)
        {   //Programm prints out user defined amount of stars, uses function to write the stars
            while (true)
            {
                int userInput;
                Console.Write("Syötä tähtien määrä: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out userInput);

                if (isNumber && userInput > 0)
                {
                    Console.WriteLine($"{amountOfStars(userInput)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Ei sallittu syöte. Syötteen pitää olla positiivinen luku!");
                }
            }
        }
        static string amountOfStars(int amount)
        {
            string value = "";

            for (int i = 0; i < amount; i++)
            {
                value += "*";
            }
            return value;
        }
    }
}