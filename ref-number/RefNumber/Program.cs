using System;
using System.IO;

namespace ref_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] factor = new int[] { 7, 3, 1 };
            ConsoleKeyInfo cki;

            do
            {
                cki = UserInterface();
                switch (cki.Key)
                {
                    case ConsoleKey.T:
                        if (RefNumberChecker(UserInput("\nSyötä viitenumero: "), factor))
                        {
                            Console.WriteLine("Viitenumero on oikein.");
                        }
                        else
                        {
                            Console.WriteLine("Viitenumero on väärä.");
                        }
                        break;

                    case ConsoleKey.L:
                        Console.WriteLine($"Viitenumero kokonaisuudessaan: {RefNumberCreator(UserInput("\nSyötä viitenumeron alkuosa: "), factor)}");
                        break;

                    case ConsoleKey.M:
                        Console.WriteLine();
                        string[] nr = RefNumberGenerator(BaseRefNumberGenerator(), factor);
                        Console.WriteLine("Luotiin seuraavat viitenumerot:");
                        for (int i = 0; i < nr.Length; i++)
                        {
                            Console.WriteLine(nr[i]);
                        }
                        WriteToFile(nr);
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("\nOhjelma suljetaan.");
                        break;

                    default:
                        Console.WriteLine("\nVäärä valinta!");
                        break;
                }
                Console.WriteLine("Press anykey!");
                Console.ReadKey();
                Console.Clear();
            } while (cki.Key != ConsoleKey.Escape);

            /*string test = UserInput("Testi     ");
            test = StringSplitter(test);
            Console.WriteLine(test);*/
        }
        static ConsoleKeyInfo UserInterface()
        {
            Console.WriteLine("[T] Tarkasta viitenumero.");
            Console.WriteLine("[L] Luo yksi viitenumero.");
            Console.WriteLine("[M] Luo viitenumeroita haluttu määrä ja tallenna ne referencenumber tiedostoon.");
            Console.WriteLine("[N] Lue viitenumerot tiedostosta, jotka tehtiin viime kerralla.");
            Console.WriteLine("[Esc] Sulje ohjelma.");
            Console.Write("Syötä valinta: ");

            return Console.ReadKey();
        }
        /// <summary>
        /// Asks user for input.
        /// Returns string.
        /// </summary>
        /// <returns></returns>
        static string UserInput(string askInput)
        {
            Console.Write(askInput);
            return Console.ReadLine();
        }
        /// <summary>
        /// Checks if Reference number is correct.
        /// Returns result as boolean.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="fact"></param>
        /// <returns></returns>
        static bool RefNumberChecker(string number, int[] fact)
        {
            int sum = 0;
            int j = number.Length - 2;

            for (int i = 0; i < number.Length - 1; i++)
            {
                int nr = Convert.ToInt32(number[j].ToString());
                sum += nr * fact[i % 3];
                j--;
            }
            int checkNumber = 10 - (sum % 10);

            if (checkNumber == 10)
            {
                checkNumber = 0;
            }

            if (checkNumber == Convert.ToInt32(number[number.Length - 1].ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Creates one reference number.
        /// Returns reference number as string.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="fact"></param>
        /// <returns></returns>
        static string RefNumberCreator(string number, int[] fact)
        {
            int sum = 0;
            int j = number.Length - 1;

            for (int i = 0; i < number.Length; i++)
            {
                int nr = Convert.ToInt32(number[j].ToString());
                sum += nr * fact[i % 3];
                j--;
            }
            int checkNumber = 10 - (sum % 10);
            if (checkNumber == 10)
            {
                checkNumber = 0;
            }
            number += checkNumber;
            number = StringSplitter(number);
            return number;
        }
        /// <summary>
        /// Creates user inputted amount of base reference numbers.
        /// Returns array of base reference numbers.
        /// </summary>
        /// <returns></returns>
        static string[] BaseRefNumberGenerator()
        {
            string baseNumber = UserInput("Syötä viitenumeron alkuosa: ");
            int count = int.Parse(UserInput("Syötä viitenumeroiden määrä: "));
            string[] refNumbers = new string[count];
            int j;

            for (int i = 0; i < refNumbers.Length; i++)
            {
                j = i + 1;
                refNumbers[i] = baseNumber + j;
            }
            return refNumbers;
        }
        /// <summary>
        /// Adds check number to the end of every Ref Number in array.
        /// Returns array of completed reference numbers.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="fact"></param>
        /// <returns></returns>
        static string[] RefNumberGenerator(string[] numbers, int[] fact)
        {
            string number;
            for (int i = 0; i < numbers.Length; i++)
            {
                number = numbers[i];
                numbers[i] = RefNumberCreator(number, fact);
            }
            return numbers;
        }
        /// <summary>
        /// Writes every ref number to .txt file.
        /// </summary>
        /// <param name="numbers"></param>
        static void WriteToFile(string[] numbers)
        {
            string path = @"C:\TEMP\referencenumber.txt";
            StreamWriter R = new StreamWriter(path);

            for (int i = 0; i < numbers.Length; i++)
            {
                R.WriteLine(numbers[i]);
            }
            R.Close();
        }
        /// <summary>
        /// Adds a space every 5th char to string from right to left.
        /// Returns string with spaces.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static string StringSplitter(string str)
        {
            int j = str.Length - 1;
            for (int i = 1; i < str.Length; i++)
            {
                if (i % 5 == 0 && j > 0)
                {
                    str = str.Insert(j, " ");
                }
                j--;
            }
            return str;
        }
    }
}