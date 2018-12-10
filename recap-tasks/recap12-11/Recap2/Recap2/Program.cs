using System;

namespace Recap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tee ohjelma, joka arpoo satunnaisluvun väliltä 1-100. " +
                "Ohjelman käyttäjän pitää arvata luku. " +
                "Ohjelma antaa vihjeitä, onko arvattu luku liian suuri vai pieni. " +
                "Jos luku ei ole lukualueella siitä tulee virheilmoitus.");

            Random rnd = new Random();
            int guessNumber = rnd.Next(100);
            while (true)
            {
                int userNumber = UserInput();

                if (userNumber < 1 || userNumber > 100)
                {
                    Console.WriteLine("Syöttämäsi luku ei ole alueelta 1-100.");
                }
                else if (userNumber == guessNumber)
                {
                    Console.WriteLine("Arvasit oikein!");
                    break;
                }
                else if (userNumber < guessNumber)
                {
                    Console.WriteLine("Arvattu luku on liian pieni.");
                }
                else if (userNumber > guessNumber)
                {
                    Console.WriteLine("Arvattu luku on liian suuri.");
                }
            }
            Console.WriteLine($"Oikea luku oli {guessNumber}.");
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