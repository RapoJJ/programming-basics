using System;

namespace StringTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma ilmoittaa käyttäjän syöttämästä syötteestä merkkien lukumäärän.");
            string strInput = UserInput();

            Console.WriteLine($"Syötteesi oli {strInput}.\nSiinä on {strInput.Length} merkkiä.");
        }
        /// <summary>
        /// Asks user for input and saves it as string.
        /// </summary>
        /// <returns></returns>
        static string UserInput()
        {
            Console.Write("Syötä lause: ");
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}