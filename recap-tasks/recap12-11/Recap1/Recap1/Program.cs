using System;

namespace Recap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää kaksi samaa lukua peräkkäin. Ohjelma tulostaa näytölle syötettyjen lukujen summan.");

            int number1 = 0;
            int number2;
            int sum = 0;

            while (true)
            {
                number2 = UserInput();
                if (number1 == number2)
                {
                    sum += number2;
                    break;
                }
                else
                {
                    number1 = number2;
                    sum += number2;                
                }
            }
            Console.WriteLine($"Syötettyjen lukujen summa: {sum}");
            
        }
        static int UserInput()
        {
            while (true)
            { 
            Console.Write("Syötä luku: ");
            bool isNumber = int.TryParse(Console.ReadLine(), out int number);

            if (isNumber)
                return number;
            }
        }
    }
}