using System;

namespace ArrayTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int average;
            int[] numbers = new int[100];
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(50);
                sum += numbers[i];
                Console.WriteLine($"{i + 1}. {numbers[i]}");
            }
            average = sum / numbers.Length;
            Console.WriteLine($"\nKA. {average}");
        }
    }
}
