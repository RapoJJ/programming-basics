using System;

namespace LoopTask1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddSum = 0;
            int evenSum = 0;

            Console.WriteLine("Ohjelma laskee N:n ensimmäisen parittoman ja parillisen lukujen summan.");
            Console.Write("Syötä luku: ");      //Asking user for input
            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out int number);        //checking if the input was number

            if (isNumber && number >= 1)        //doing the loop if input was number and atleast 1
            {
                for (int i = 1; i <= number; i++)
                {
                    if (i % 2 == 0)
                        evenSum = evenSum + i;
                    else
                        oddSum = oddSum + i;
                }
                Console.WriteLine($"Vastaus: Parittomien summa = {oddSum}, Parillisten summa = {evenSum}");
            }
            else
                Console.WriteLine("Antamasi syöte ei kelpaa");
        }
    }
}