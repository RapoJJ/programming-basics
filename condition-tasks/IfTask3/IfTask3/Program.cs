using System;

namespace IfTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku positiivinen vai negatiivinen" +
                "ja onko luku pariton vai parillinen");
            Console.Write("Syötä luku: ");
            string userInput = Console.ReadLine();
            int number = 0;
            string posOrNeg = "";
            string evenOrOdd = "";
            bool isNumber = int.TryParse(userInput, out number);

            if (isNumber)
            {
                if (number % 2 == 0)
                    evenOrOdd = "parillinen";
                else
                    evenOrOdd = "pariton";

                if (number == 0)
                    posOrNeg = "nolla";
                else if (number > 0)
                    posOrNeg = "positiivinen";
                else
                    posOrNeg = "pariton";
            }
            else
                Console.WriteLine("Syöte ei ole luku");

            Console.WriteLine($"Syöttämäsi luku {number} on {posOrNeg} ja {evenOrOdd}");


        }
    }
}
