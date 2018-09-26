using System;

namespace IfTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku pariton vai parillinen.");
            Console.Write("Syötä luku: ");
            string userInput = Console.ReadLine();
            int number = 0;
            bool isNumber = int.TryParse(userInput, out number);

            if (isNumber)
            {
                if (number == 0)
                    Console.WriteLine($"Syöttämäsi luku {number} on nolla.");
                else if (number % 2 == 0)
                    Console.WriteLine($"Syöttämäsi luku {number} on parillinen.");
                else
                    Console.WriteLine($"Syöttämäsi luku {number} on pariton.");
            }
            else
                Console.WriteLine("Syöte ei ole luku.");
        }
    }
}
