using System;

namespace id_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string idNr = UserInput();


        }
        /// <summary>
        /// User Interface
        /// </summary>
        /// <returns></returns>
        static string UserInterface()
        {
            Console.WriteLine("Henkilötunnuksen käsittely.");
            Console.WriteLine("[T] Tarkista henkikötunnuksen oikeellisuus.");
            Console.WriteLine("[U] Luo uusi henkilötunnus.");
            Console.WriteLine("[X] Sulje ohjelma.");
            Console.Write("Valitse mitä tehdään: ");

            return Console.ReadLine();
        }
        /// <summary>
        /// Asks user for input, returns it as string
        /// </summary>
        /// <returns></returns>
        static string UserInput()
        {
            Console.Write("Syötä henkikötunnus muodossa (PPKKVV-XXXQ): ");
            return Console.ReadLine();
        }

        /*static bool IdDateChecker (string id)
         {
             string dateAndMonth = "";

             int day = int.Parse(id.Substring(0, 2));
             int month = int.Parse(id.Substring(2, 2));

             if (month > 0 && month < 13 && day > 0 && day < 32)
             {
                 if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12 && day < 32)
                 {
                     dateAndMonth = "Päivä ja kuukausi on oikein";
                     return true;
                 }
             }

         }*/
         /// <summary>
         /// Calculates last char of ID number.
         /// Returns last char.
         /// </summary>
         /// <param name="id"></param>
         /// <returns></returns>
        static char CalculateLastChar(string id)
        {
            string lastChars = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            int luku = int.Parse(id.Substring(0, 6) + id.Substring(7, 3));
            return lastChars[luku % 31];
        }
    }
}