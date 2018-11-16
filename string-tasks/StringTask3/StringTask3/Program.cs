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
            Console.WriteLine($"Syöte: {strInput}\nSyötteessä on {CountOfChar(strInput, countThis)} {countThis} kirjainta.");
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
        /// Counts how many characters there is in a string.
        /// x = any string
        /// y = any char
        /// Returns number of the characters.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static int CountOfChar(string x, char y)
        {
            int count = 0;
            x = x.ToUpper();
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == y)
                {
                    count++;
                }
            }
            return count;
        }
        /// <summary>
        /// Asks user to input character.
        /// Returns user chosen character.
        /// </summary>
        /// <returns></returns>
        static char ChooseChar ()
        {
            Console.Write("Syötä kirjain, jonka lukumäärä lasketaan: ");
            char UserInput = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            return UserInput;
        }
    }
}