using System;

namespace StringTaskVocalCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee käyttäjän syöttämästä tiedosta vokaalien lukumäärän.");
            string word = UserInput();
            Console.WriteLine($"Syötteessä '{word}' on {VowelCount(word)} vokaalia.");

            //Console.WriteLine($"Sanassa {word} on {word.Length - VowelsRemoved(word).Length} vokaalia.");

            //Console.WriteLine($"Sanassa {word} on {OnlyVowels(word).Length} vokaalia.");

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
        /// Counts how many vowels there are in a string.
        /// Returns count of vowels as int.
        /// sentence = any string
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        static int VowelCount(string sentence)
        {
            sentence = sentence.ToLower();
            int count = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u' || sentence[i] == 'y' || sentence[i] == 'ä' || sentence[i] == 'ö')
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
        /// <param name="sentence"></param>
        /// <returns></returns>
        static string VowelsRemoved(string sentence)
        {
            sentence = sentence.ToLower();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u' || sentence[i] == 'y' || sentence[i] == 'ä' || sentence[i] == 'ö')
                {
                    sentence = sentence.Remove(i, 1);
                    i--;
                }
            }
            return sentence;
        }
        /// <summary>
        /// Deletes anything that isn't vowel from string
        /// Returns string with only vowels.
        /// sentence = any string
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        static string OnlyVowels(string sentence)
        {
            sentence = sentence.ToLower();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != 'a' && sentence[i] != 'e' && sentence[i] != 'i' && sentence[i] != 'o' && sentence[i] != 'u' && sentence[i] != 'y' && sentence[i] != 'ä' && sentence[i] != 'ö')
                {
                    sentence = sentence.Remove(i, 1);
                    i--;
                }
            }
            return sentence;
        }
    }
}