using System;

namespace Recap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arvaa luku väliltä 1-100.");
            int counter = 0;
            Random rnd = new Random();
            int guessNumber = rnd.Next(100);
            while (true)
            {
                int userNumber = UserInput();

                if (userNumber < 1 || userNumber > 100)
                {
                    Console.WriteLine("Syöttämäsi luku ei ole alueelta 1-100.");
                    counter++;
                }
                else if (userNumber == guessNumber)
                {
                    Console.WriteLine("Arvasit oikein!");
                    break;
                }
                else if (userNumber < guessNumber)
                {
                    Console.WriteLine("Arvattu luku on liian pieni.");
                    counter++;
                }
                else if (userNumber > guessNumber)
                {
                    Console.WriteLine("Arvattu luku on liian suuri.");
                    counter++;
                }
            }
            Console.WriteLine($"Oikea luku oli {guessNumber}. Arvaus kertoja ennen oikeaa vastausta oli {counter}");
        }
        static int UserInput()
        {
            while (true)
            {
                Console.Write("Arvaa luku: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out int number);

                if (isNumber)
                    return number;
            }
        }
    }
}