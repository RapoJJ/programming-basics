using System;

namespace ArrayRecap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tee funktio, joka palauttaa parametrina annetun määrän tähtiä.");

            int[] numbers = new int[] { 2, 5, 10, 7, 3 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(StarPrinter(numbers[i]));
            }
        }
        /// <summary>
        /// Returns a string with stars, int amount defines how many stars the string holds.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        static string StarPrinter(int amount)
        {
            string stars = "";
            for (int i = 0; i < amount; i++)
            {
                stars += "*";
            }
            return stars;
        }
    }
}