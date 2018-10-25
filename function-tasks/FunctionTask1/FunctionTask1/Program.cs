using System;

namespace FunctionTask1
{
    class Program
    {
        static void Main(string[] args)
        {   //Programm prints out user defined amount of stars, uses function to write the stars
            while (true)
            {
                Console.Write("Syötä tähtien määrä: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);

                if (isNumber && userInput > 0)
                {
                    Console.WriteLine($"{AmountOfStars(userInput)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Ei sallittu syöte. Syötteen pitää olla positiivinen luku!");
                }
            }
        }
        static string AmountOfStars(int amount)
        {
            string stars = "";

            for (int i = 1; i <= amount; i++)
            {
                stars += "*";
            }
            return stars;
        }
    }
}