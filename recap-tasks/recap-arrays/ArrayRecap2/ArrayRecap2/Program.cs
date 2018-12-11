using System;

namespace ArrayRecap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma, jossa määrittelet kaksi kolmipaikkaista taulukkoa. " +
                "Alusta toinen tuotteiden nimillä ja toinen niiden hinnoilla. " +
                "Tämän jälkeen, tulosta jokaisen tuotteen nimi ja hinta yhdessä omalle riville.");

            //Esimerkkituloste:
            //MacBook Air   928,90€ 
            //Jolla         349,00€ 
            //Nokia         99,80€
            string[] items = new string[3] { "Macbook Air", "Jolla", "Nokia" };
            string[] prices = new string[3] { "928,90€", "349,00€", "99,80€" };

            ArrayPrinter(items, prices);
        }
        /// <summary>
        /// Prints info from two arrays.
        /// </summary>
        /// <param name="names"></param>
        /// <param name="euros"></param>
        static void ArrayPrinter(string[] names, string[] euros)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]}\t{euros[i]}");
            }
        }
    }
}