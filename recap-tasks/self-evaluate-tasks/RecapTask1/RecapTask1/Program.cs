using System;

namespace RecapTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma, kysyy käyttäjältä sanan tai lauseen ja tulostaa sen 5 kertaa.");
            string empty = "";
            string printout = UserSentence(empty);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(printout);
            }
        }
        static string UserSentence(string sentence)
        {
            Console.Write("Syötä haluamasi lause/sana: ");
            sentence = Console.ReadLine();
            return sentence;
        }
    }
}
