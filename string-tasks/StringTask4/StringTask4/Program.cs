using System;

namespace StringTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkastaa onko käyttäjältä kysytty sana tai lause palindromi.");
            string userInput = UserInput();

            if (IsPalindrome(userInput))
                Console.WriteLine($"Sana {userInput} on palindromi.");
            else
                Console.WriteLine($"Sana {userInput} ei ole palindromi.");
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
        /// Checks if string is a palindrome.
        /// Deletes empty spaces inbetween words.
        /// Returns true of false value.
        /// str = any string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static bool IsPalindrome(string str)
        {
            str = str.ToUpper();
            str = str.Replace(" ", "");
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}