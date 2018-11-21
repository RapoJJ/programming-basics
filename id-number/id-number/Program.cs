using System;

namespace id_number
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface();
        }
        static string UserInterface ()
        {
            Console.WriteLine("Henkilötunnuksen käsittely");
            Console.WriteLine("[U] Luo uuden henkilötunnuksen");
            Console.WriteLine("[T] Tarkistaa henkikötunnuksen oikeellisuuden");
            Console.WriteLine("[X] Sulkee ohjelman");
            Console.Write("Valitse mitä tehdään: ");

            return Console.ReadLine();
        }
    }
}
