using System;

namespace StringTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma muuttaa käyttäjän syöttämästä syötteestä e kirjaimet @ merkiksi.");
            string input = UserInput();

            Console.WriteLine($"Syöte: {input}\nMuutettu syöte: {ReplacedString(input)}");
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
        /// <summary>
        /// Replaces character e to @ in string.
        /// Returns string with replaced characters.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static string ReplacedString (string x)
        {
            x = x.ToLower();
            string newString = x.Replace("e", "@");
            return newString;
        }
    }
}