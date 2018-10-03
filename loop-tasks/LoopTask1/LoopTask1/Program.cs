using System;

namespace LoopTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa käyttäjän kysytyn luvun kertoman.");
            Console.Write("Syötä luku: ");
            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out int number);
            int answer = 1;

            if (isNumber && number >= 1)
            {
                for (int i = 1; i <= number; i++)
                    answer = answer * i;
                Console.WriteLine($"Antamasi luvun ({userInput}) kertoma: {answer}");
            }
            else
                Console.WriteLine("Antamasi syöte ei kelpaa");
        }
    }
}