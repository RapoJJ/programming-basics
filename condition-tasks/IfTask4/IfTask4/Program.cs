using System;

namespace IfTask4
{
    class Program
    {   //Käyttäjältä pyydetään 3 lukua. Ohjelma lajittelee luvut nousevaan järjestykseen.
        static void Main(string[] args)
        {
            Console.Write("Syötä 1. luku: ");       //1. luku käyttäjältä
            string userInput = Console.ReadLine();
            int no1 = int.Parse(userInput);

            Console.Write("Syötä 2. luku: ");       //2. luku käyttäjältä
            userInput = Console.ReadLine();
            int no2 = int.Parse(userInput);

            Console.Write("Syötä 3. luku: ");       //3. luku käyttäjältä
            userInput = Console.ReadLine();
            int no3 = int.Parse(userInput);

            int smallNo = 0;
            int middleNo = 0;
            int bigNo = 0;

            if (no1 > no2)
                if (no2 > no3)
                {
                    smallNo = no3;
                    middleNo = no2;
                    bigNo = no1;
                }
                else
                    if (no1 > no3)
                    {
                        smallNo = no2;
                        middleNo = no3;
                        bigNo = no1;
                    }
                    else
                    {
                        smallNo = no2;
                        middleNo = no1;
                        bigNo = no3;
                    }
            else
                if (no1 > no3)
                {
                    smallNo = no3;
                    middleNo = no1;
                    bigNo = no2;
                }
                else
                    if (no3 > no2)
                    {
                        smallNo = no1;
                        middleNo = no2;
                        bigNo = no3;
                    }
                    else
                    {
                        smallNo = no1;
                        middleNo = no3;
                        bigNo = no2;
                    }
            Console.WriteLine($"{smallNo}, {middleNo}, {bigNo}");
        }
    }
}
