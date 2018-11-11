using System;

namespace StringTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma ilmoittaa käyttäjän syöttämästä syötteestä merkkien lukumäärän.");
            string strInput = UserInput();

            Console.WriteLine($"Syötteesi oli {strInput}.\nSiinä on {LengthOfString(ref strInput)} merkkiä.");

        }
        static string UserInput()
        {
            Console.Write("Syötä lause: ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        static int LengthOfString(ref string x)
        {
            int length = x.Length;
            return length;
        }
    }
}