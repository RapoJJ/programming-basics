using System;

namespace LoopTask2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi kolikon heittoa käyttäjältä kysytyn määrän verran ja ottaa tulokset talteen");

            int i = 1;
            int headsAmount = 0;
            int tailsAmount = 0;
            int throwResult = 1;
            Random rnd = new Random();

            Console.Write("Syötä heittojen määrä: ");
            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out int throwAmount);

            if (isNumber && throwAmount > 0)
            {
                do
                {
                    throwResult = rnd.Next(2);
                    //Console.WriteLine(throwResult);
                    i++;
                    if (throwResult == 0)
                        tailsAmount++;
                    else
                        headsAmount++;
                } while (i <= throwAmount);
            }
            else
                Console.WriteLine("Syöte ei kelpaa.");
            Console.WriteLine($"Klaavoja tuli {tailsAmount} ja kruunuja {headsAmount}.");
        }
    }
}