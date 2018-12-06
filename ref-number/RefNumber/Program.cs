using System;
using System.IO;

namespace ref_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\TEMP\referencenumber.txt";
            int[] factor = new int[] { 7, 3, 1 };
            ConsoleKeyInfo cki;

            do
            {
                cki = UserInterface();
                Console.WriteLine();
                switch (cki.Key)
                {
                    case ConsoleKey.T:
                        if (RefNumberChecker(UserInput("Syötä viitenumero: ", 4), factor))
                        {
                            Console.WriteLine("Viitenumero on oikein.");
                        }
                        else
                        {
                            Console.WriteLine("Viitenumero on väärä.");
                        }
                        break;

                    case ConsoleKey.L:
                        Console.WriteLine($"Viitenumero kokonaisuudessaan: {RefNumberCreator(UserInput("Syötä viitenumeron alkuosa: ", 3), factor)}");
                        break;

                    case ConsoleKey.M:
                        string[] nr = RefNumberGenerator(BaseRefNumberGenerator(), factor);
                        Console.WriteLine("Luotiin seuraavat viitenumerot:");
                        for (int i = 0; i < nr.Length; i++)
                        {
                            Console.WriteLine(nr[i]);
                        }
                        WriteToFile(nr, path);
                        break;
                    case ConsoleKey.N:
                        ReadFile(path);
                        break;
                        
                    case ConsoleKey.Escape:
                        Console.WriteLine("Ohjelma suljetaan.");
                        break;

                    default:
                        Console.WriteLine("Väärä valinta!");
                        break;
                }
                Console.WriteLine("Press anykey!");
                Console.ReadKey();
                Console.Clear();
            } while (cki.Key != ConsoleKey.Escape);

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
        /// askInput = string which defines what user is inputting.
        /// lenght = min length allowed for input.
        /// </summary>
        /// <returns></returns>
        static string UserInput(string askInput, int length)
        {                  
            while (true)
            {
                Console.Write(askInput);
                string input = Console.ReadLine();
                bool isNumber = int.TryParse(input, out int number);
                if (isNumber)
                {
                    if (input.Length >= length)
                    {
                        return input;
                    }
                    else
                    {
                        Console.WriteLine("Viitenumeron pitää olla vähintään 4 numeroinen (3 + tarkiste)!");
                        Console.Write("Yritä uudestaan: ");
                        input = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Syötteen pitää olla luku.");
                }
            }
        }
        /// <summary>
        /// Checks if Reference number is correct.
        /// Returns result as boolean.
        /// number = reference number as string.
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
        /// number = reference number as string.
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
            string baseNumber = UserInput("Syötä viitenumeron alkuosa: ", 3);
            int count = int.Parse(UserInput("Syötä viitenumeroiden määrä: ", 1));
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
        /// numbers = array of base reference numbers
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
        /// <summary>
        /// Writes every ref number to .txt file.
        /// path = path of the file.
        /// </summary>
        /// <param name="numbers"></param>
        static void WriteToFile(string[] numbers, string path)
        {           
            StreamWriter R = new StreamWriter(path);

            for (int i = 0; i < numbers.Length; i++)
            {
                R.WriteLine(numbers[i]);
            }
            R.Close();
        }
        /// <summary>
        /// Reads data from file.
        /// path = path of the file.
        /// </summary>
        /// <param name="path"></param>
        static void ReadFile(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;

                    Console.WriteLine("Aikaisemmin luodut viitenumerot: ");
                    while ((line = sr.ReadLine()) != null )
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Tapahtui virhe: { ex.Message}");
            }
        }
    }
}