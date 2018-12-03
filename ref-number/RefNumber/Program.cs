using System;

namespace ref_number
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static char UserInterface()
        {
            Console.WriteLine("[T] Tarkasta viitenumero.");
            Console.WriteLine("[L] Luo viitenumeroita haluttu määrä.");
            Console.WriteLine("[x] Sulje ohjelma.");
            Console.Write("Syötä valinta:");

            return char.ToUpper(Console.ReadKey().KeyChar);
        }



    }
}
