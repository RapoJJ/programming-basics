using System;

namespace ArrayTask3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo yksiuloitteiseen kokonaisluku(koko 10) taulukkoon arvot[0, 20[");

            int[] numbers = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(20);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i}. {numbers[i]:d2}");
            }
        }
    }
}