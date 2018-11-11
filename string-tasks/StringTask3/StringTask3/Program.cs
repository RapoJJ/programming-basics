using System;

namespace StringTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee käyttäjän syöttämästä syötteestä vaikkapa L kirjainten lukumäärän.");
            string strInput = UserInput();
            char countThis = ChooseChar();
            Console.WriteLine($"Syöte: {strInput}\nSyötteessä on {CountOfChar(ref strInput, ref countThis)} {countThis} kirjainta");
        }
        static string UserInput()
        {
            Console.Write("Syötä lause: ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        static int CountOfChar(ref string x, ref char y)
        {
            int count = 0;
            x = x.ToLower();
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == y)
                {
                    count++;
                }
            }
            return count;
        }
        static char ChooseChar ()
        {
            Console.Write("Syötä kirjain, jonka lukumäärä lasketaan: ");
            char UserInput = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();
            return UserInput;
        }
    }
}