using System;

namespace IfTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku pariton vai parillinen.");
            Console.Write("Anna luku: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number == 0)
                Console.WriteLine($"Syöttämäsi luku {number} on nolla.");
            else if (number % 2 == 0)
                Console.WriteLine($"Syöttämäsi luku {number} on parillinen.");
            else
                Console.WriteLine($"Syöttämäsi luku {number} on pariton.");
        }
    }
}
