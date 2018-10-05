using System;

namespace LoopTask1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen myös negatiivisilla numeroilla.");
            Console.Write("Syötä luku: ");      //Asking user for input
            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out int number);    //Checking if the input was number
            int sum = 0;

            if (isNumber)       //Doing the loop if the input was number
            {
                if (number > 0)         //If the number was positive
                    for (int i = 0; i <= number; i++)       
                        sum = sum + i;
                else                    //If the number was negative
                    for (int i = 0; i >= number; i--)
                        sum = sum + i;
                Console.WriteLine($"Vastaus: {sum}");
            }
            else
                Console.WriteLine("Antamasi syöte ei kelpaa");
        }
    }
}