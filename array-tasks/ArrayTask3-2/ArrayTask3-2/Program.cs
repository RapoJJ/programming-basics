using System;

namespace ArrayTask3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[10, 20];
            Random rnd = new Random();

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = rnd.Next(100);
                }
            }
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine($"[{i},{j}] = {numbers[i, j]:d2}");
                }
            }
        }
    }
}
