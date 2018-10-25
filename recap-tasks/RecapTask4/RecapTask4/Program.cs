using System;

namespace RecapTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelmalle syötetään kaksi lukua. Ohjelma tulostaa yhteen-, vähennys-, kerto- ja jakolasku näistä luvuista");

            //Numbers(out double number1, out double number2);

            double number1 = 0;
            double number2 = 0;

            number1 = Number(number1);
            number2 = Number(number2);

            Console.WriteLine($"{Rounder(number1)} + {Rounder(number2)} = {Rounder(Sum(number1, number2))}");
            Console.WriteLine($"{Rounder(number1)} - {Rounder(number2)} = {Rounder(Difference(number1, number2))}");
            Console.WriteLine($"{Rounder(number1)} * {Rounder(number2)} = {Rounder(Multiply(number1, number2))}");
            Console.WriteLine($"{Rounder(number1)} / {Rounder(number2)} = {Rounder(Division(number1, number2))}");
        }
        static double Number(double x)
        {
            while (true)
            {
                Console.Write("Syötä 1. luku: ");
                bool isNumber = double.TryParse(Console.ReadLine(), out x);

                if (isNumber)
                {
                    return x;
                }
                else
                {
                    Console.WriteLine("Syötteen pitää olla numero!");
                }
            }
        }
        /*static void Numbers(out double number1, out double number2)
        {
            while (true)
            {
                Console.Write("Syötä 1. luku: ");
                bool isNumber = double.TryParse(Console.ReadLine(), out number1);

                if (isNumber)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Syötteen pitää olla numero!");
                }
            }
            while (true)
            {
                Console.Write("Syötä 2. luku: ");
                bool isNumber = double.TryParse(Console.ReadLine(), out number2);

                if (isNumber)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Syötteen pitää olla numero!");
                }
            }
        }*/
        static double Rounder(double number)
        {
            number = Math.Round(number, 2);
            return number;
        }
        static double Sum(double x, double y)
        {
            double sum = x + y;
            return sum;
        }
        static double Difference(double x, double y)
        {
            double diff = x - y;
            return diff;
        }
        static double Multiply(double x, double y)
        {
            double multi = x * y;
            return multi;
        }
        static double Division(double x, double y)
        {
            double div = x / y;
            return div;
        }
    }
}