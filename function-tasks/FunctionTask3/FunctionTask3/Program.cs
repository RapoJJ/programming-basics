using System;

namespace FunctionTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Käyttäjä pyydetään luku väliltä 1-20, lukua kysytään uudestaan jos se " +
                "ei ole annetulta väliltä.");
            int number = NumberFromRange(1, 20);
            Console.WriteLine($"Syöttämäsi luku {number} on väliltä 1-20.");
        }
        static int NumberFromRange(int lowerBound, int upperBound)
        {
            while (true)
            {
                Console.Write("Syötä luku (1-20): ");
                bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);

                if (isNumber && userInput >= lowerBound && userInput <= upperBound)
                {
                    Console.WriteLine();
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Syöttämäsi luku ei ollut väliltä 1-20.");
                }
            }
        }
    }
}