using System;

namespace IfTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku positiivinen vai negatiivinen sekä onko luku pariton vai parillinen.");
            int number = 0;
            string posOrNeg = "";
            string evenOrOdd = "";

            Console.Write("Syötä luku: ");
            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out number);

            if (isNumber)
            {
                //Tarkistetaan onko pariton vai parillinen
                if (number % 2 == 0)
                    evenOrOdd = "parillinen";
                else
                    evenOrOdd = "pariton";

                //Tarkistetaan onko positiivinen, negatiivinen vai nolla
                if (number == 0)
                    posOrNeg = "nolla";
                else if (number > 0)
                    posOrNeg = "positiivinen";
                else
                    posOrNeg = "negatiivinen";
            }
            else
                Console.WriteLine("Syöte ei ole luku.");

            Console.WriteLine($"Syöttämäsi luku {number} on {posOrNeg} ja {evenOrOdd}.");
        }
    }
}