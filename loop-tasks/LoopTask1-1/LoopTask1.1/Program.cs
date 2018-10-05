using System;

namespace LoopTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa käyttäjältä kysytyn luvun kertoman.");
            Console.Write("Syötä luku: ");      //Asking user to input a number
            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out int number); //checking if input is number
            int answer = 1;

            if (isNumber && number >= 1)    //only doing the loop if the input is number and is atleast 1
            {
                for (int i = 1; i <= number; i++)
                    answer = answer * i;
                Console.WriteLine($"Antamasi luvun ({userInput}) kertoma: {answer}");
            }
            else     //input was wrong
                Console.WriteLine("Antamasi syöte ei kelpaa");
        }
    }
}