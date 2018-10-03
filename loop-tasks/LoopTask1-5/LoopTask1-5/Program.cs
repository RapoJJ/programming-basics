using System;

namespace LoopTask1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma käyttäjän syöttämän luvun ensimmäisen parittoman ja parillisen lukujen summan tai erotuksen. ");
            Console.Write("Syötä luku: ");
            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out int number);
            int oddSum = 0;
            int evenSum = 0;

            if (isNumber)
            {
                if (number > 0)
                    for (int i = 0; i <= number; i++)
                        if (i % 2 == 0)
                            evenSum = evenSum + i;
                        else
                            oddSum = oddSum + i;
                else
                    for (int i = 0; i >= number; i--)
                        if (i % 2 == 0)
                            evenSum = evenSum + i;
                        else
                            oddSum = oddSum + i;
                Console.WriteLine($"Vastaus: Parittomien summa = {oddSum}, Parillisten summa = {evenSum}");
            }
            else
                Console.WriteLine("Antamasi syöte ei kelpaa");
        }
    }
}