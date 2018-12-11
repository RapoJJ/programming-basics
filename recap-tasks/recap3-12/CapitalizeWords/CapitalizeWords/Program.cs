using System;
using System.Linq;

namespace CapitalizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tee ohjelma, joka muuttaa lauseen sanat alkamaan isoilla kirjaimilla.");

            string[] preposition = { "the", "of", "in", "a", "an", "to", "and", "at", "from", "by", "on", "or" };
            string sentence = UserInput();

            string[] splitSentence = StringSplitter(sentence);
            string[] splitSentenceCapitalized = WordCapitalizer(splitSentence, preposition);

            string sentenceCapitalized = SentenceUniter(splitSentenceCapitalized);

            Console.WriteLine($"Syötit lauseen: {sentence}");
            Console.WriteLine($"Lauseen sanat muutettu oikeaan muotoon: {sentenceCapitalized}");
        }
        /// <summary>
        /// Asks user for input, returns input as string.
        /// </summary>
        /// <returns></returns>
        static string UserInput()
        {
            Console.Write("Syötä lause: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Slipts string into words space as splitter.
        /// Returns array of words.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static string[] StringSplitter(string str)
        {
            string[] sentenceByWords = str.Split(' ');
            return sentenceByWords;
        }
        /// <summary>
        /// Capitalizes words in string array if they dont belong to string[] preposistions.
        /// Returns array of capitalized words.
        /// </summary>
        /// <param name="words"></param>
        /// <param name="prepositions"></param>
        /// <returns></returns>
        static string[] WordCapitalizer(string[] words, string[] prepositions)
        {
            string word;
            for (int i = 0; i < words.Length; i++)
            {
                word = words[i].ToLower();
                for (int j = 0; j < prepositions.Length; j++)
                {
                    if (i == 0)
                    {
                        words[i] = char.ToUpper(word[0]) + word.Substring(1);
                        break;
                    }
                    else if (word == prepositions[j])
                    {
                        words[i] = word;
                        break;
                    }
                    else
                    {
                        words[i] = char.ToUpper(word[0]) + word.Substring(1);
                    }
                }
            }
            return words;
        }
        /// <summary>
        /// Unites words in array to one string.
        /// Returns sentence as string.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        static string SentenceUniter(string[] words)
        {
            string sentence;
            char separator = ' ';
            sentence = string.Join(separator, words);
            return sentence;
        }
    }
}
