using System;

namespace FunctionTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma pyytää käyttäjältä 2 lukua ja tulostaa niistä pienemmän ja isomman.");
            while (true)
            {
                Console.Write("Syötä 1. luku: ");
                bool isNumber1 = int.TryParse(Console.ReadLine(), out int userInput1);
                Console.Write("Syötä 2. luku: ");
                bool isNumber2 = int.TryParse(Console.ReadLine(), out int userInput2);

                if (isNumber1 && isNumber2)
                {
                    Console.WriteLine($"Luku {smallerNumber(userInput1, userInput2)} on pienempi kuin " +
                        $"{biggerNumber(userInput1, userInput2)}.");
                    break;
                }
                else
                {
                    Console.WriteLine("Väärä syöte. Syötä numerot uudestaan!");
                }
            }
        }
        static int smallerNumber(int number1, int number2)
        {
            int smallerNumber;

            if (number1 > number2)
            {
                smallerNumber = number2;
            }
            else
            {
                smallerNumber = number1;
            }
            return smallerNumber;
        }
        static int biggerNumber(int number1, int number2)
        {
            int biggerNumber;

            if (number1 > number2)
            {
                biggerNumber = number1;
            }
            else
            {
                biggerNumber = number2;
            }
            return biggerNumber;
        }
    }
}