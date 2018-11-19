using System;

namespace StringTaskVocalCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee käyttäjän syöttämästä tiedosta vokaalien lukumäärän.");
            string word = UserInput();
            //Console.WriteLine($"Syötteessä '{word}' on {VowelCount(word)} vokaalia.");

            Console.WriteLine($"Sanassa {word} on {word.Length - VowelsRemoverClass(word).Length} vokaalia.");

            //Console.WriteLine($"Sanassa {word} on {OnlyVowels(word).Length} vokaalia.");
        }
        /// <summary>
        /// Asks user for input and saves it as string.
        /// </summary>
        /// <returns></returns>
        static string UserInput()
        {
            Console.Write("Syötä sana tai lause: ");
            string userInput = Console.ReadLine();
            return userInput;
        }
        /// <summary>
        /// Counts how many vowels there are in a string.
        /// Returns count of vowels as int.
        /// sentence = any string
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        static int VowelCount(string d)
        {
            d = d.ToLower();
            int count = 0;
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] == 'a' || d[i] == 'e' || d[i] == 'i' || d[i] == 'o' || d[i] == 'u' || d[i] == 'y' || d[i] == 'ä' || d[i] == 'ö')
                {
                    count++;
                }
            }
            return count;
        }
        /// <summary>
        /// Removes vowels from string.
        /// Returns string without vowels.
        /// sentence = any string
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        static string VowelsRemover(string d)
        {
            d = d.ToLower();
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] == 'a' || d[i] == 'e' || d[i] == 'i' || d[i] == 'o' || d[i] == 'u' || d[i] == 'y' || d[i] == 'ä' || d[i] == 'ö')
                {
                    d = d.Remove(i, 1);
                    i--;
                }
            }
            return d;
        }
        /// <summary>
        /// Deletes anything that isn't vowel from string
        /// Returns string with only vowels.
        /// sentence = any string
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        static string OnlyVowels(string d)
        {
            d = d.ToLower();
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] != 'a' && d[i] != 'e' && d[i] != 'i' && d[i] != 'o' && d[i] != 'u' && d[i] != 'y' && d[i] != 'ä' && d[i] != 'ö')
                {
                    d = d.Remove(i, 1);
                    i--;
                }
            }
            return d;
        }
        /// <summary>
        /// Removes vowels from string.
        /// Returns string without vowels.
        /// sentence = any string
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        static string VowelsRemoverClass(string d)
        {
            string vowels = "aieouyöä";
            d = d.ToLower();

            for (int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (d[i] == vowels[j])
                    {
                        d = d.Remove(i, 1);
                        i--;
                        break;
                    }
                }
            }
            return d;
        }
    }
}