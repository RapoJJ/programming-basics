using System;

namespace LoopTask1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen.");
            Console.Write("Syötä luku: ");      //Asking user for input
            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out int number);    //checking if input is number
            int sum = 0;

            if (isNumber && number >= 1)    //doing the loop if input was number and atleast 1
            {
                for (int i = 1; i <= number; i++)
                    sum = sum + i;
                Console.WriteLine($"Vastaus: {sum}");
            }
            else
                Console.WriteLine("Antamasi syöte ei kelpaa");
        }
    }
}