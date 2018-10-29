using System;

namespace FunctionTask4Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä 10 lukua.");
            LargestNumber();
        }

        static int LargestNumber()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}.");
                int userNumber = int.Parse(Console.ReadLine());

            }
            return 0;
        }
    }

}
