using System;

namespace LoopTask1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma käyttäjän syöttämän luvun ensimmäisen parittoman ja parillisen lukujen summan. ");
            Console.Write("Syötä luku: ");
            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out int number);
            int oddSum = 0;
            int evenSum = 0;

            if (isNumber && number >= 1)
            {
                for (int i = 1; i <= number; i++)
                    if (i % 2 == 0)
                        evenSum = evenSum+ i;
                    else
                        oddSum = oddSum + i;
                Console.WriteLine($"Vastaus: Parittomien summa = {oddSum}, Parillisten summa = {evenSum}");
            }
            else
                Console.WriteLine("Antamasi syöte ei kelpaa");
        }
    }
}