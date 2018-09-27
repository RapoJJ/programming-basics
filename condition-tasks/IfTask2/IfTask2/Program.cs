using System;

namespace IfTask2
{
    class Program
    {
        static void Main(string[] args)
        {   //Program determines if user gets discount for tickets or not
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double ticketPrice = 16.00;
            double discount = 0;

            Console.WriteLine($"Lipun hinta ilman alennuksia on {ticketPrice}.");
            Console.Write("Syötä ikä: ");           //Asking users age
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
                Console.Write("1. Varusmies\n2. Opiskelija\n3. Opiskelija sekä MTK jäsen\n" +
                    "4. MTK jäsen\n5. Ei mikään\nValitse sopiva kategoria (1-5): ");
                string userInput1 = Console.ReadLine();
                int userChoice = int.Parse(userInput1);

                if (userChoice == 1)            //Setting discount to predetermined value
                    discount = 0.5;
                else if (userChoice == 2)
                    discount = 0.45;
                else if (userChoice == 3)
                    discount = 0.60;
                else if (userChoice == 4)
                    discount = 0.15;
                else if (userChoice == 5)
                    discount = 0;
            }
            Console.WriteLine($"Uusi lipunhinta on {ticketPrice - ticketPrice * discount}€."); //Printing new price
        }
    }
}
