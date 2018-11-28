using System;
using System.IO;

namespace FileClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\temp\testi.dat");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}