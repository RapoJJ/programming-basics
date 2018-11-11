using System;

namespace StringTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma muuttaa käyttäjän syöttämästä syötteestä e kirjaimet @ merkiksi.");

            string input = UserInput();

            Console.WriteLine($"Syöte: {input}\nMuutettu syöte: {ReplacedString(ref input)}");
        }
        static string UserInput()
        {
            Console.Write("Syötä lause: ");
            string userInput = Console.ReadLine();
            return userInput;
        }
        static string ReplacedString (ref string x)
        {
            string stringNew = x.Replace("e", "@");
            return stringNew;
        }
    }
}