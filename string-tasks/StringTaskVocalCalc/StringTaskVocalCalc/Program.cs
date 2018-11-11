using System;

namespace StringTaskVocalCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee käyttäjän syöttämästä tiedosta vokaalien lukumäärän.");
            string word = UserInput();
            Console.WriteLine($"Sanassa {word} on {VowelCount(word)} vokaalia.");

            //Console.WriteLine($"Sanassa {word} on {word.Length - VowelsRemoved(word).Length} vokaalia.");

            //Console.WriteLine($"Sanassa {word} on {OnlyVowels(word).Length} vokaalia.");

        }
        static string UserInput()
        {
            Console.Write("Syötä lause: ");
            string userInput = Console.ReadLine();
            return userInput;
        }
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