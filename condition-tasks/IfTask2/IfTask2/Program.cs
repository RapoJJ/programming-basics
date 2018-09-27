using System;

namespace IfTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double ticketPrice = 16.00;
            double discount = 0;

            Console.Write("Syötä ikä: ");
            string userInput = Console.ReadLine();
            int userAge = int.Parse(userInput);

            if (userAge < 7)        //Checking users age for discounts
                discount = 1;
            else if (userAge >= 65)
                discount = 0.5;
            else if (userAge > 7 && userAge < 15)   
                discount = 0.5;
            else                    //If users age doesnt grant a discount
            {
                Console.Write("Valitse sopiva kategoria\n1. Varusmies\n2. Opiskelija\n3. Opiskelija ja MTK jäsen\n" +
                    "4. MTK jäsen\n5. Ei mikään\n");
                string userInput1 = Console.ReadLine();
                int userChoice = int.Parse(userInput1);

                if (userChoice == 1)
                    discount = 0.5;
                else if (userChoice == 2)
                    discount = 0.45;
                else if (userChoice == 3)
                    discount = 0.60;
                else if (userChoice == 4)
                    discount = 0.15;
                else if (userChoice == 5)
                    discount = 0;
                else
                    Console.WriteLine("Väärä syöte");


            }
            Console.WriteLine($"Lipunhintasi on {ticketPrice - ticketPrice * discount}€.");


        }
    }
}
