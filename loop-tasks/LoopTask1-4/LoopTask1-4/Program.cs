using System;

namespace LoopTask1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen myös negatiivisilla numeroilla.");
            Console.Write("Syötä luku: ");
            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out int number);
            int sum = 0;

            if (isNumber)
            {
                if (number > 0)
                    for (int i = 0; i <= number; i++)
                        sum = sum + i;
                else
                    for (int i = 0; i >= number; i--)
                        sum = sum + i;
                Console.WriteLine($"Vastaus: {sum}");
            }
            else
                Console.WriteLine("Antamasi syöte ei kelpaa");
        }
    }
}