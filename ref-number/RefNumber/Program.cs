using System;

namespace ref_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] factor = new int[] { 7, 3, 1 };
            //Console.WriteLine(RefNumberCreator(UserInput(), factor));
            //Console.WriteLine(RefNumberChecker(UserInput(), factor));

            string[] nr = RefNumberGenerator(BaseRefNumberGenerator(), factor);


            for (int i = 0; i < nr.Length; i++)
            {
                Console.WriteLine(nr[i]);
            }
        }
        static ConsoleKeyInfo UserInterface()
        {
            Console.WriteLine("[T] Tarkasta viitenumero.");
            Console.WriteLine("[L] Luo viitenumeroita haluttu määrä.");
            Console.WriteLine("[X] Sulje ohjelma.");
            Console.Write("Syötä valinta:");

            return Console.ReadKey();
        }
        /// <summary>
        /// Asks user for input.
        /// Returns string.
        /// </summary>
        /// <returns></returns>
        static string UserInput()
        {
            Console.Write("Syötä viitenumero: ");
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
            return number;
        }
        /// <summary>
        /// Creates user inputted amount of base reference numbers.
        /// Returns array of base reference numbers.
        /// </summary>
        /// <returns></returns>
        static string[] BaseRefNumberGenerator()
        {
            Console.Write("Syötä viitenumeron alkuosa: ");
            string baseNumber = Console.ReadLine();

            Console.Write("Syötä viitenumeroiden määrä: ");
            int count = int.Parse(Console.ReadLine());

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
        /// 
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="fact"></param>
        /// <returns></returns>
        static string[] RefNumberGenerator(string[] numbers, int[] fact)
        {
            string number = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                number = numbers[i];
                int sum = 0;
                int k = number.Length - 1;
                for (int j = 0; j < number.Length; j++)
                {
                    int nr = Convert.ToInt32(number[k].ToString());
                    sum += nr * fact[j % 3];
                    k--;
                }
                int checkNumber = 10 - (sum % 10);
                if (checkNumber == 10)
                {
                    checkNumber = 0;
                }
                numbers[i] = number + checkNumber;
            }
            return numbers;
        }
    }
}