using System;
using System.Text.RegularExpressions;

namespace id_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string idNr;
            char userChoice;
            do
            {
                userChoice = UserInterface();
                Console.WriteLine();
                switch (userChoice)
                {
                    case 'T':
                        {
                            idNr = UserInput();
                            if (IdDateChecker(idNr))
                            {
                                Console.WriteLine(IdNumberChecker(idNr, CalculateLastChar(idNr)));
                            }
                            else
                            {
                                Console.WriteLine("Päivämäärä ei ole mahdollinen!");
                            }
                            break;
                        }
                    case 'U':
                        {
                            idNr = UserInput();
                            if (IdDateChecker(idNr))
                            {
                                Console.WriteLine($"Henkilötunnuksen tarkiste merkki on: {CalculateLastChar(idNr)}");
                                Console.WriteLine($"Henkilötunnus kokonaisuudessaan: {idNr}{CalculateLastChar(idNr)}");
                            }
                            else
                            {
                                Console.WriteLine("Päivämäärä ei ole mahdollinen!");
                            }
                            break;
                        }
                    case 'X':
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Väärä valinta!");
                            break;
                        }
                }
                Console.WriteLine("Press anykey!");
                Console.ReadKey();
                Console.Clear();
            } while (userChoice != 'X');
        }
        /// <summary>
        /// User Interface
        /// </summary>
        /// <returns></returns>
        static char UserInterface()
        {
            Console.WriteLine("Henkilötunnuksen käsittely.");
            Console.WriteLine("[T] Tarkista henkikötunnuksen oikeellisuus.");
            Console.WriteLine("[U] Luo uusi henkilötunnus.");
            Console.WriteLine("[X] Sulje ohjelma.");
            Console.Write("Valitse mitä tehdään: ");

            return char.ToUpper(Console.ReadKey().KeyChar);
        }
        /// <summary>
        /// Asks user for input, returns it as string
        /// </summary>
        /// <returns></returns>
        static string UserInput()
        {

            Console.Write("Syötä henkikötunnus tai sen alkuosa muodossa (PPKKVV-XXX[Q]): ");
            string id = Console.ReadLine().ToUpper();
            while (true)
            {
                //if (id.Length == 10 || id.Length == 11)
                if (new Regex("\\d{6}[-+ABCDEFGH]\\d{3}[0-9A-Y]?").IsMatch(id))
                    return id;
                else
                {
                    Console.WriteLine("Henkilötunnus ei ole oikeassa muodossa!");
                    Console.Write("Syötä uusi henkilötunnus tai sen alkuosa (PPKKVV-XXX[Q]): ");
                    id = Console.ReadLine().ToUpper();
                }
            }
        }
        /// <summary>
        /// Checks if the date in idNumber is right.
        /// </summary>
        /// <param name="id"></param>
        static bool IdDateChecker(string id)
        {
            int day = int.Parse(id.Substring(0, 2));
            int month = int.Parse(id.Substring(2, 2));
            int year = int.Parse(id.Substring(4, 2));

            string centuryChar = "+-ABCDEFGH";
            int j = 0;
            int centuryInt = 1800;
            for (int i = 0; i < centuryChar.Length; i++)
            {
                if (id.Contains(centuryChar[i]))
                {
                    year += centuryInt + i * j;
                }
                j += 100;
            }
            bool correct = true;
            try
            {
                DateTime d = new DateTime(year, month, day);
            }
            catch
            {
                correct = false;
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
            if (id.Length == 11)
            {
                if (id[10] == lastChar)
                {
                    return "Henkilötunnus on oikea.";
                }
                else
                    return "Henkikötunnus on väärä.";
            }
            else
                
            return $"Et syöttänyt koko henkikötunnusta!\n" +
                    $"Henkilötunnus on kokonaisuudessaan: {id}{lastChar}";
        }
    }
}