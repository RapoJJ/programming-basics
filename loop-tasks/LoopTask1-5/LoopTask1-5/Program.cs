using System;

namespace LoopTask1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddSum = 0;
            int evenSum = 0;

            Console.WriteLine("Ohjelma laskee N:n ensimmäisen parittoman ja parillisen lukujen summan tai erotuksen.");
            Console.Write("Syötä luku: ");  //Asking user for input
            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out int number);    //checking if the input was number

            if (isNumber)           
            {
                if (number > 0)             //If the input number was positive
                    for (int i = 0; i <= number; i++)
                        if (i % 2 == 0)     //If i is even
                            evenSum = evenSum + i;
                        else                //i is odd
                            oddSum = oddSum + i;
                else                        //If the input number was negative
                    for (int i = 0; i >= number; i--)
                        if (i % 2 == 0)     //if i is even
                            evenSum = evenSum + i;
                        else                //i is odd
                            oddSum = oddSum + i;
                Console.WriteLine($"Vastaus: Parittomien summa = {oddSum}, Parillisten summa = {evenSum}");
            }
            else
                Console.WriteLine("Antamasi syöte ei kelpaa");
        }
    }
}