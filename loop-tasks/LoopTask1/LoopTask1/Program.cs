using System;

namespace LoopTask1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ohjelma tulostaa käyttäjän antaman luvun kertoman.");
            Console.Write("Syötä luku: ");
            string userInput = Console.ReadLine();
            int number = 0;
            bool isNumber = int.TryParse(userInput, out number);


            if (isNumber)
                if (number >= 1)
                    int factorial = number

        }
    }
}
