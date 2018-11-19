using System;

namespace RefNumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma1. joka tarkastaa kotimaisen viitenumeron, 2.luo kotimaisen viitenumero " +
                "3.luo halutun määrän kotimaisia viitenumeroita");
        }


        static string UserInput()
        {
            Console.WriteLine("Syötä viitenumero: ");
            return Console.ReadLine();
        }
    }
}