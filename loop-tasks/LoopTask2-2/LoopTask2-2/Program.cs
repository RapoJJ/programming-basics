using System;

namespace LoopTask2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1-9.");
            int numberOne = 1;
            int numberTwo = 1;
            int answer = 1;

            for (numberOne = 1; numberOne <= 9; numberOne++)
            {
                for (numberTwo = 1; numberTwo <= 9; numberTwo++)
                {
                    answer = numberOne * numberTwo;
                    Console.WriteLine($"{numberOne} x {numberTwo} = {answer}");
                }
            }
        }
    }
}
