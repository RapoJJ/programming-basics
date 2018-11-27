using System;

namespace id_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string idNr = UserInput();
            char checkMark = CalculateLastChar(idNr);

            IdDateChecker(idNr);
            Console.WriteLine(IdNumberChecker(idNr, checkMark));

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
            return Console.ReadLine().ToUpper();
        }
        /// <summary>
        /// Checks if the date in idNumber is right.
        /// </summary>
        /// <param name="id"></param>
        static int IdDateChecker(string id)
        {
            int day = int.Parse(id.Substring(0, 2));
            int month = int.Parse(id.Substring(2, 2));
            int year = int.Parse(id.Substring(4, 2));

            if (id[6] == '-')
            {
                year += 1900;
            }
            else if (id[6] == 'A')
            {
                year += 2000;
            }
            else if (id[6] == '+')
            {
                year += 1800;
            }
            int correct = 1;
            try
            {
                DateTime d = new DateTime(year, month, day);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                correct = 0;
            }
            return correct;
        }
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
        /// <summary>
        /// Checks id numbers last char.
        /// Returns string which tells the user if id number was right or wrong.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lastChar"></param>
        /// <returns></returns>
        static string IdNumberChecker(string id, char lastChar)
        {
            char idLastChar = id[10];
            if (idLastChar == lastChar)
            {
                return "Henkilötunnus on oikein.";
            }
            else
                return "Henkikötunnus on väärä.";
        }
    }
}