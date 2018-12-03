using System;

namespace ref_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] factor = new int[] { 7, 3, 1 };
            //Console.WriteLine(RefNumberChecker(UserInput()));

            Console.WriteLine(RefNumberCreator(UserInput(), factor));
        }
        static char UserInterface()
        {
            Console.WriteLine("[T] Tarkasta viitenumero.");
            Console.WriteLine("[L] Luo viitenumeroita haluttu määrä.");
            Console.WriteLine("[X] Sulje ohjelma.");
            Console.Write("Syötä valinta:");

            return char.ToUpper(Console.ReadKey().KeyChar);
        }
        static string UserInput()
        {
            Console.Write("Syötä viitenumero: ");
            return Console.ReadLine();
        }
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

            if (checkNumber == Convert.ToInt32(number[number.Length - 1].ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
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

            number += checkNumber;
            return number;
        }
        static void RefNumberGenerator()
        {

        }
    }
}