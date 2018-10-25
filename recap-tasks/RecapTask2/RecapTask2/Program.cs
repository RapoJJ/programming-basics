using System;

namespace RecapTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kysyy käyttäjältä sanan tai lauseen ja tulostaa sen niin monta kertaa näytölle kuin sanassa on kirjaimia");
            string empty = "";
            
            string printout = UserSentence(empty);

            int sentenceLength = printout.Length;

            for (int i = 0; i < sentenceLength; i++)
            {
                Console.WriteLine($"{i}. {printout}");
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